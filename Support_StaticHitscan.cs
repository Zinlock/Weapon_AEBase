if($Pref::staticHitscan::stepSpeed $= "")
	$Pref::staticHitscan::stepSpeed = 33;
	
$WindVector = "0 0 0";

datablock StaticShapeData(AEBulletStaticShape)
{
	shapeFile = "./newbullet.dts";
};

function getBounceVector(%vector, %normal)
{
	%v = %vector;
	%n = %normal;
	return vectorSub(%v, vectorScale(%n, 2 * vectorDot(%v, %n)));
}
function getStepDistance_ae(%data)
{
	%ups = %data.staticUnitsPerSecond;
	
	%updates = 1000 / $Pref::staticHitscan::stepSpeed;
	%distance = %ups / %updates;
	
	return %distance;
}
function getSwayVector(%sway)
{
	return getSway(%sway) SPC getSway(%sway) SPC 0;
}
function getSway(%sway)
{
	return getRandom() * 0.0001 * getRandom(-1, 1) * %sway;
}
function createStaticHitscan_aebase(%player, %sourceImage, %initialPosition, %vector, %step, %initPos, %staticObject)
{
	// First step
	if(!%step)
		%initPos = %initialPosition;
	
	// player vars
	%client = %player.client;
	
	// projectile vars
	%data = %sourceImage.projectile;
	%stepDistance = getStepDistance_ae(%sourceImage);
	%stepSpeed = $Pref::staticHitscan::stepSpeed;
		
	// init raycast
	%start = %initialPosition;
	%end = vectorAdd(%start, vectorScale(%vector, %stepDistance));
	%mask = $TypeMasks::FxBrickObjectType |
			$TypeMasks::PlayerObjectType |
			$TypeMasks::VehicleObjectType |
			$TypeMasks::TerrainObjectType |
			$TypeMasks::StaticObjectType;
	
	%mount = 0;
	if(isObject(%player))
		%mount = %player.getObjectMount();

	%raycast = containerRayCast(%start, %end, %mask, %player, %mount);
	%hit = getWord(%raycast, 0);
	%hitPosition = getWords(%raycast, 1, 3);
	
	// for when we hit something
	if(%hit)
	{
		if(isFunction(%data.getName(), "onStaticHitscanStep"))
		{
			%data.onStaticHitscanStep(%player, %start, %hitPosition, %vector, %staticObject, %sourceImage);
		}
	
		if(isObject(%staticObject))
			%staticObject.delete();
		
		%directDamage = %sourceImage.projectileDamage;
		%headshotMult = %sourceImage.projectileHeadshotMult;
		%vehicleMult = %sourceImage.projectileVehicleDamageMult;

		%tag = %sourceImage.projectileTagStrength;
		%tagRec = %sourceImage.projectileTagRecovery;

		if(%player.getClassName() $= "Player")
		{
			if(%player.AEDamageMult !$= "")
				%directDamage *= %player.AEDamageMult;
			else
				%directDamage *= $Pref::AEBase::playerDamageMult;
			%headshotMult *= $Pref::AEBase::playerHeadshotMult;
			if(%vehicleMult $= "")
				%vehicleMult = $Pref::AEBase::playerVehicleDamageMult;

			if(!%sourceImage.projectileTagIgnore)
			{
				%tagRec *= $Pref::AEBase::playerTagRecoveryMult;
				%tag *= $Pref::AEBase::playerTagMult;
			}
		}
		else
		{
			if(%player.AEDamageMult !$= "")
				%directDamage *= %player.AEDamageMult;
			else
				%directDamage *= $Pref::AEBase::botDamageMult;
			%headshotMult *= $Pref::AEBase::botHeadshotMult;
			if(%vehicleMult $= "")
				%vehicleMult = $Pref::AEBase::botVehicleDamageMult;

			if(!%sourceImage.projectileTagIgnore)
			{
				%tagRec *= $Pref::AEBase::botTagRecoveryMult;
				%tag *= $Pref::AEBase::botTagMult;
			}
		}
	
		// create the projectile at the location of the impact
		%realProjectile = new Projectile()
		{
			datablock = %sourceImage.projectile;
			initialPosition = vectorAdd(getWords(%raycast, 1, 3), vectorScale(%vector, -0.1));
			initialVelocity = vectorScale(%vector, 200);
			client = %client;
			sourceObject = %player;
			minigame = %minigame;
			sourceSlot = 0;
			sourceImage = %sourceImage;
			scale = %sourceImage.bulletScale;
			directDamage = %directDamage;
			vehicleDamage = %vehicleMult;
			headshotMult = %headshotMult;
			sonicWhizz = %sourceImage.sonicWhizz;
			whizzSupersonic = %sourceImage.whizzSupersonic;
			whizzThrough = %sourceImage.whizzThrough;
			whizzDistance = %sourceImage.whizzDistance;
			whizzChance = %sourceImage.whizzChance;
			whizzAngle = %sourceImage.whizzAngle;
			tagStrength = %tag;
			tagRecover = %tagRec;
			RGibExplosionBody = %sourceImage.projectileRGibExplosionBody;
			RGibExplosionHead = %sourceImage.projectileRGibExplosionHead;
			sourcePosition = %initPos;
			falloffStart = %sourceImage.projectileFalloffStart;
			falloffEnd = %sourceImage.projectileFalloffEnd;
			falloffDamage = %sourceImage.projectileFalloffDamage;
			directDamageType = %sourceImage.directDamageType;
			directHeadDamageType = %sourceImage.directHeadDamageType;
			RDismemberBody = %sourceImage.projectileRDismemberBody;
			RDismemberHead = %sourceImage.projectileRDismemberHead;
		};

		//%realProjectile.schedule(32, explode);
		
		// in some cases with this method the shooter can shoot themselves (???) so prevent this from causing damage
		%realProjectile.dontHurtShooter = true;
		return;
	}
	
	// didn't hit anything
	// get some info about our projectile
	%effectiveRange = %sourceImage.staticEffectiveRange;
	%totalRange = %sourceImage.staticTotalRange;
	%gravity = %sourceImage.staticGravityScale;
	%sway = %sourceImage.staticSwayMod;
	%speedBonus = %sourceImage.staticEffectiveSpeedBonus;
	%useFakeProjectileEffect = %sourceImage.staticSpawnFakeProjectiles;
	%useTracer = %sourceImage.staticTracerEffect;
	%scaleCalibre = %sourceImage.staticScaleCalibre;
	%scaleLength = %sourceImage.staticScaleLength;
	
	// didn't find what we needed, set def values
	if(%totalRange $= "") %totalRange = 2000;
	if(%effectiveRange $= "") %effectiveRange = 200;
	if(%sway $= "") %sway = 0;
	if(%speedBonus $= "") %speedBonus = 1;
	if(%useTracer $= "") %useTracer = AEBulletStaticShape;
		
	// get our current range
	%currentRange = vectorDist(%initPos, %end);
	
	if(%currentRange > %effectiveRange)
	{
		// outside effective range
		// wind and sway
		%vector = vectorNormalize(vectorAdd(vectorAdd(%vector, vectorScale($WindVector, %sway)), getSwayVector(%sway)));
		
		// gravity
		%gravity = %gravity * 0.001;
		%vector = vectorNormalize(vectorAdd(%vector, "0 0" SPC %gravity * -1));
	}
	
	// create a static shape that gives the illusion of a bullet traveling very fast, move it to a new position each time
	if(%useFakeProjectileEffect && $Pref::AEBase::staticTracers)
	{
		// aligning static shape to direction of travel
		// written by conan
		%rot = vectorNormalize(%vector);
		%xyz = vectorNormalize(vectorCross("1 0 0", %rot)); //rotation axis
		%u = mACos(vectorDot("1 0 0", %rot)) * -1; //rotation value
		%rot = %xyz SPC %u;

		// if we already have a static shape, just move it to the new position
		if(isObject(%staticObject))
		{
			%staticObject.setTransform(%start SPC %rot);
			%staticObject.playThread(1, travel);
		}
		else
		{
			// if not, create a new one
			if(%step > 0)
			{
				%datablock = %useTracer;
				
				%staticObject = new StaticShape()
				{
					datablock = %datablock;
				};

				%staticObject.setTransform(%start SPC %rot);
				%staticObject.setScale(%scaleLength SPC %scaleCalibre SPC %scaleCalibre);
				%staticObject.playThread(1, travel);

				MissionCleanup.add(%staticObject);
			}
		}
	}
	
	if(isFunction(%data.getName(), "onStaticHitscanStep"))
	{
		%data.onStaticHitscanStep(%player, %start, %end, %vector, %staticObject, %sourceImage);
	}

	// we're outside of our total range, don't continue
	if(%currentRange > %totalRange)
	{
		if(isObject(%staticObject))
			%staticObject.delete();
			
		return;
	}
	
	// sentinel for bogus loops, 1000 is still even a massive value, could probably be 200
	if(%step > 1000)
	{
		if(isObject(%staticObject))
			%staticObject.delete();
	
		return;
	}
	
	// next step
	schedule(%stepSpeed, 0, createStaticHitscan_aebase, %player, %sourceImage, %end, %vector, %step++, %initPos, %staticObject);
}

package staticProjectilePackage_ae
{
	function ProjectileData::onCollision(%this, %obj, %col, %fade, %pos, %normal, %velocity)
	{		
		// Prevents the user from shooting themselves when shooting directly down or against a wall
		if(%obj.dontHurtShooter && %col.client == %obj.client && %col.getClassName() $= "Player")
		{
			return;
		}
		
		Parent::onCollision(%this, %obj, %col, %fade, %pos, %normal, %velocity);
	}
};
activatePackage(staticProjectilePackage_ae);