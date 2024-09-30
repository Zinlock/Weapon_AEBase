// not the raycasting weapons you're looking for

function ShapeBase::fireRaycastProjectile(%pl, %img, %start, %dir)
{
	if((%range = %img.staticTotalRange) $= "")
		%range = 1000;

	if((%tracer = %img.staticSpawnFakeProjectiles) $= "")
		%tracer = 1;
	
	%dir = vectorNormalize(%dir);

	%end = vectorAdd(%start, vectorScale(%dir, %range));
	%mask = $TypeMasks::FxBrickObjectType |
			$TypeMasks::PlayerObjectType |
			$TypeMasks::VehicleObjectType |
			$TypeMasks::TerrainObjectType |
			$trapStaticTypemask;
	%start2 = %start;
	%start = vectorAdd(%start, vectorScale(%dir, -%range/1000));

	%dist = vectorDist(%start, %end);
	%int = 100;
	%cts = mFloor(%dist / %int);

	if(%cts <= 0)
		%cts = 1;

	for(%i = 0; %i < %cts; %i++)
	{
		%point = vectorAdd(%start, vectorScale(%dir, %int * %i));

		if(%i >= %cts - 1)
			%ray = containerRayCast(%point, vectorAdd(%point, vectorScale(%dir, %range - (%int * %i))), %mask, %pl, %pl.getObjectMount());
		else
			%ray = containerRayCast(%point, vectorAdd(%point, vectorScale(%dir, %int)), %mask, %pl, %pl.getObjectMount());
		%col = getWord(%ray, 0);

		if(!isObject(%col))
			%pos = %end;
		else
		{
			%pos = getWords(%ray, 1, 3);

			%directDamage = %img.projectileDamage;
			%headshotMult = %img.projectileHeadshotMult;
			%vehicleMult = %img.projectileVehicleDamageMult;

			%tag = %img.projectileTagStrength;
			%tagRec = %img.projectileTagRecovery;

			if(%pl.getClassName() $= "Player")
			{
				if(%pl.AEDamageMult !$= "")
					%directDamage *= %pl.AEDamageMult;
				else
					%directDamage *= $Pref::AEBase::playerDamageMult;
				%headshotMult *= $Pref::AEBase::playerHeadshotMult;
				if(%vehicleMult $= "")
					%vehicleMult = $Pref::AEBase::playerVehicleDamageMult;

				if(!%img.projectileTagIgnore)
				{
					%tagRec *= $Pref::AEBase::playerTagRecoveryMult;
					%tag *= $Pref::AEBase::playerTagMult;
				}
			}
			else
			{
				if(%pl.AEDamageMult !$= "")
					%directDamage *= %pl.AEDamageMult;
				else
					%directDamage *= $Pref::AEBase::playerDamageMult;
				%headshotMult *= $Pref::AEBase::botHeadshotMult;
				if(%vehicleMult $= "")
					%vehicleMult = $Pref::AEBase::botVehicleDamageMult;

				if(!%img.projectileTagIgnore)
				{
					%tagRec *= $Pref::AEBase::botTagRecoveryMult;
					%tag *= $Pref::AEBase::botTagMult;
				}
			}
		
			%realProjectile = new Projectile()
			{
				datablock = %img.projectile;
				initialPosition = vectorAdd(%pos, vectorScale(%dir, -0.1));
				initialVelocity = vectorScale(%dir, 200);
				client = %pl.Client;
				sourceObject = %pl;
				minigame = %pl.Client.minigame;
				sourceSlot = 0;
				sourceImage = %img;
				scale = %img.bulletScale;
				directDamage = %directDamage;
				vehicleDamage = %vehicleMult;
				headshotMult = %headshotMult;
				sonicWhizz = %img.sonicWhizz;
				whizzSupersonic = %img.whizzSupersonic;
				whizzThrough = %img.whizzThrough;
				whizzDistance = %img.whizzDistance;
				whizzChance = %img.whizzChance;
				whizzAngle = %img.whizzAngle;
				tagStrength = %tag;
				tagRecover = %tagRec;
				RGibExplosionBody = %img.projectileRGibExplosionBody;
				RGibExplosionHead = %img.projectileRGibExplosionHead;
				sourcePosition = %start;
				falloffStart = %img.projectileFalloffStart;
				falloffEnd = %img.projectileFalloffEnd;
				falloffDamage = %img.projectileFalloffDamage;
				directDamageType = %img.directDamageType;
				directHeadDamageType = %img.directHeadDamageType;
				RDismemberBody = %img.projectileRDismemberBody;
				RDismemberHead = %img.projectileRDismemberHead;
			};

			%realProjectile.dontHurtShooter = true;
			break;
		}
	}

	if(%tracer > 0 && $Pref::AEBase::staticTracers)
	{
		%shape = new StaticShape()
		{
			datablock = (%img.staticTracerEffect $= "" ? BulletTrailStatic : %img.staticTracerEffect);
		};
		MissionCleanup.add(%shape);

		%x = getWord(%dir,0) / 2;
		%y = (getWord(%dir,1) + 1) / 2;
		%z = getWord(%dir,2) / 2;

		%shape.setTransform(%start2 SPC VectorNormalize(%x SPC %y SPC %z) SPC mDegToRad(180));
		%shape.setScale(%tracer SPC vectorDist(%start2,%pos) SPC %tracer);
	}
}