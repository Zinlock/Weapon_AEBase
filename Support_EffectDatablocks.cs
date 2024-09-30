////////////////////////////////////////////////                    ////////////////////////////////////////////////
//////////////////////////////////////////////// UNIVERSAL EMITTERS ////////////////////////////////////////////////
////////////////////////////////////////////////                    ////////////////////////////////////////////////

// BULLET TRAILS

datablock ParticleData(gc_bulletDebrisExplosionParticle)
{
	dragCoefficient = 0;
	gravityCoefficient = 5;
	inheritedVelFactor = 0.2;
	constantAcceleration = 0;
	lifetimeMS = 1000;
	lifetimeVarianceMS = 500;
	textureName = "base/data/particles/chunk";
	spinSpeed = 10;
	spinRandomMin = -500;
	spinRandomMax = 500;
	colors[0] = "0 0 0 1";
	colors[1] = "0 0 0 0";
	sizes[0] = 0.1;
	sizes[1] = 0.1;
	useInvAlpha = true;
};

datablock ParticleEmitterData(gc_bulletDebrisExplosionEmitter)
{
	uiName = "";
	ejectionPeriodMS = 3;
	periodVarianceMS = 0;
	ejectionVelocity = 8;
	velocityVariance = 8;
	ejectionOffset = 0;
	thetaMin = 0;
	thetaMax = 30;
	phiReferenceVel = 0;
	phiVariance = 360;
	overrideAdvance = false;
	particles = "gc_bulletDebrisExplosionParticle";
};

datablock ParticleData(GenericExplosionParticle)
{
	dragCoefficient      = 8;
	gravityCoefficient   = -0.1;
	inheritedVelFactor   = 0.2;
	constantAcceleration = 0.0;
	lifetimeMS           = 1500;
	lifetimeVarianceMS   = 500;
	textureName          = "base/data/particles/cloud";
	spinSpeed		= 10.0;
	spinRandomMin		= -50.0;
	spinRandomMax		= 50.0;
	colors[0]     = "0.6 0.6 0.6 0.2";
	colors[1]     = "0.5 0.5 0.5 0.0";
	sizes[0]      = 0.75;
	sizes[1]      = 2;
	useInvAlpha = true;
};
datablock ParticleEmitterData(GenericExplosionEmitter)
{
   lifeTimeMS		= 30;
   ejectionPeriodMS = 3;
   periodVarianceMS = 0;
   ejectionVelocity = 7;
   velocityVariance = 1.0;
   ejectionOffset   = 0.0;
   thetaMin         = 89;
   thetaMax         = 90;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   particles = "GenericExplosionParticle";
};

datablock ParticleData(AERifleTrailParticle)
{
	dragCoefficient		= 5000.0;
	windCoefficient		= 0.0;
	gravityCoefficient	= 0.0;
	inheritedVelFactor	= 0.0;
	constantAcceleration	= 0.0;
	lifetimeMS		= 350;
	lifetimeVarianceMS	= 0;
	spinSpeed		= 10.0;
	spinRandomMin		= -50.0;
	spinRandomMax		= 50.0;
	useInvAlpha		= false;
	animateTexture		= false;
	//framesPerSec		= 1;

  textureName = "./Particles/trail";
	//animTexName		= "~/data/particles/dot";

	// Interpolation variables
	colors[0]     = "0.9 0.4 0.3 0.3";
	colors[1]     = "0.9 0.3 0.0 0.1";
	colors[2]     = "0.9 0.3 0.0 0";
	sizes[0]	= 0.3;
	sizes[1]	= 0.15;
	sizes[2]	= 0.0;
	times[0]	= 0.0;
	times[1]	= 0.25;
	times[2]	= 1.0;
};

datablock ParticleEmitterData(AERifleTrailEmitter)
{
   ejectionPeriodMS = 1;
   periodVarianceMS = 0;
   ejectionVelocity = 0; //0.25;
   velocityVariance = 0; //0.10;
   ejectionOffset = 0;
   thetaMin         = 0.0;
   thetaMax         = 90.0;  

   particles = AERifleTrailParticle;

   useEmitterColors = true;
};

// SILENCED TRAIL

datablock ParticleData(AESilencedTrailParticle)
{
	dragCoefficient		= 5000.0;
	windCoefficient		= 0.0;
	gravityCoefficient	= 0.0;
	inheritedVelFactor	= 0.0;
	constantAcceleration	= 0.0;
	lifetimeMS		= 350;
	lifetimeVarianceMS	= 0;
	spinSpeed		= 10.0;
	spinRandomMin		= -50.0;
	spinRandomMax		= 50.0;
	useInvAlpha		= false;
	animateTexture		= false;
	//framesPerSec		= 1;

  textureName = "./Particles/trail";
	//animTexName		= "~/data/particles/dot";

	// Interpolation variables
	colors[0]     = "0.15 0.15 0.15 0.1";	
	colors[1]     = "0.15 0.15 0.15 0.03";
	colors[2]     = "0.15 0.15 0.15 0.0";
	sizes[0]	= 0.3;
	sizes[1]	= 0.15;
	sizes[2]	= 0.0;
	times[0]	= 0.0;
	times[1]	= 0.25;
	times[2]	= 1.0;
};

datablock ParticleEmitterData(AESilencedTrailEmitter)
{
   ejectionPeriodMS = 1;
   periodVarianceMS = 0;
   ejectionVelocity = 0; //0.25;
   velocityVariance = 0; //0.10;
   ejectionOffset = 0;
   thetaMin         = 0.0;
   thetaMax         = 90.0;  

   particles = AESilencedTrailParticle;

   useEmitterColors = true;
};

// COOL DUST EFFECT EMITTER/PARTICLE (taken from swollow's weapons)

datablock ParticleData(ImpactFragmentParticle)
{
	dragCoefficient      = 1;
	gravityCoefficient   = 0.4;
	inheritedVelFactor   = 0.2;
	constantAcceleration = 0.0;
	lifetimeMS           = 800;
	lifetimeVarianceMS   = 100;
	textureName          = "base/data/particles/cloud";
	spinSpeed			= 10.0;
	spinRandomMin		= -50.0;
	spinRandomMax		= 50.0;
	colors[0]			= "0.6 0.6 0.6 0.3";
	colors[1]			= "0.5 0.5 0.5 0.0";
	sizes[0]			= 0.25;
	sizes[1]			= 0.75;
	useInvAlpha 		= true;
};

datablock ParticleEmitterData(ImpactFragmentEmitter)
{
	ejectionPeriodMS	= 1;
	periodVarianceMS	= 0;
	ejectionVelocity	= 2;
	velocityVariance	= 1.0;
	ejectionOffset  	= 0.0;
	thetaMin			= 89;
	thetaMax			= 90;
	phiReferenceVel		= 0;
	phiVariance			= 360;
	overrideAdvance		= false;
	particles			= ImpactFragmentParticle;
};

// edited color of default gun ring emitter

datablock ParticleData(AEExplosionRingParticle)
{
	dragCoefficient      = 8;
	gravityCoefficient   = -0.5;
	inheritedVelFactor   = 0.2;
	constantAcceleration = 0.0;
	lifetimeMS           = 50;
	lifetimeVarianceMS   = 35;
	textureName          = "base/data/particles/star1";
	spinSpeed		= 500.0;
	spinRandomMin		= -500.0;
	spinRandomMax		= 500.0;
	colors[0]     = "1 0.35 0.0 0.9";
	colors[1]     = "0.9 0.0 0.0 0.0";
	sizes[0]      = 1;
	sizes[1]      = 0;

	useInvAlpha = false;
};
datablock ParticleEmitterData(AEExplosionRingEmitter)
{
	lifeTimeMS = 50;

   ejectionPeriodMS = 3;
   periodVarianceMS = 0;
   ejectionVelocity = 0;
   velocityVariance = 0.0;
   ejectionOffset   = 0.0;
   thetaMin         = 89;
   thetaMax         = 90;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   particles = "AEExplosionRingParticle";

   useEmitterColors = true;
   uiName = "Orange Gun Hit Flash";
};

////////////////////////////////////////////////                       ////////////////////////////////////////////////
//////////////////////////////////////////////// UNIVERSAL PROJECTILES ////////////////////////////////////////////////
////////////////////////////////////////////////                       ////////////////////////////////////////////////

// MUZZLE FLASH LIGHT PROJECTILE

datablock ExplosionData(AEFlashExplosion) //i know this isn't supposed to be here but it doesn't work otherwise lel
{
   lifeTimeMS = 100;
   lightStartRadius = 5;
   lightEndRadius = 7;
   lightStartColor = "0.9 0.8 0.7";
   lightEndColor = "0.9 0.5 0.0";
};
datablock ProjectileData(AEFlashProjectile)
{
	projectileShapeName	= "base/data/shapes/empty.dts";
	directDamage		= 0;
	lifetime			= 25;
	fadeDelay			= 25;
    armingDelay			= 0;
	muzzleVelocity		= 0;
	explodeondeath		= true;
	explosion			= AEFlashExplosion;
};

// SCREENSHAKE STUFF PROJECTILE

datablock ExplosionData(ScreenShakeSmallExplosion)
{
   explosionShape = "";

   lifeTimeMS = 150;

   faceViewer     = true;
   explosionScale = "1 1 1";

   shakeCamera = true;
  camShakeFreq = "1 1 1";
  camShakeAmp = "0.1 0.3 0.2";
   camShakeDuration = 0.5;
   camShakeRadius = 1.0;
};

datablock ExplosionData(ScreenShakeMediumExplosion)
{
   explosionShape = "";

   lifeTimeMS = 150;

   faceViewer     = true;
   explosionScale = "1 1 1";

   shakeCamera = true;
  camShakeFreq = "2 2 2";
  camShakeAmp = "0.3 0.5 0.4";
   camShakeDuration = 0.5;
   camShakeRadius = 1.0;
};

datablock ProjectileData(ScreenShakeSmallProjectile)
{
	lifetime						= 10;
	fadeDelay						= 10;
	explodeondeath						= true;
	explosion						= ScreenShakeSmallExplosion;

    uiName = "Screen Shake Small";
};

datablock ProjectileData(ScreenShakeMediumProjectile)
{
	lifetime						= 10;
	fadeDelay						= 10;
	explodeondeath						= true;
	explosion						= ScreenShakeMediumExplosion;

    uiName = "Screen Shake Medium";
};

datablock ExplosionData(RWeaponRecoilExplosion)
{
   //explosionShape = "";
	//soundProfile = "";

   //lifeTimeMS = 0;

   //particleEmitter = "";
   //particleDensity = 0;
   //particleRadius = 0;

   //emitter[0] = gunExplosionRingEmitter;

   faceViewer     = true;
   explosionScale = "1 1 1";

   shakeCamera = true;
   camShakeFreq = "8.0 8.0 8.0";
   camShakeAmp = "2.0 2.0 2.0";
   camShakeDuration = 1.0;
   camShakeRadius = 2.0;

   // Dynamic light
   //lightStartRadius = 0;
   //lightEndRadius = 0;
   //lightStartColor = "0.0 0.0 0.0";
   //lightEndColor = "0 0 0";
};
datablock ProjectileData(R_ShotgunRecoilProjectile)
{
	projectileShapeName = "base/data/shapes/empty.dts";
	explosion           = RWeaponRecoilExplosion;
   
    lifetime            = 0;
	explodeOnDeath		= true;
};

// datablock ExplosionData(AESwayExplosion)
// {
// 	faceViewer     = true;
// 	explosionScale = "1 1 1";

// 	shakeCamera = true;
// 	camShakeFreq = "0.1 0.1 0.1";
// 	camShakeAmp = "0.05 0.05 0.05";
// 	camShakeDuration = 4.0;
// 	camShakeRadius = 1.6;
// 	camShakeFalloff = 0.0;
// };

// datablock ProjectileData(AESwayProjectile)
// {
// 	projectileShapeName = "base/data/shapes/empty.dts";
// 	explosion           = AESwayExplosion;
   
//   lifetime            = 1;
// 	explodeOnDeath		= true;
// };

////////////////////////////////////////////////                                   ////////////////////////////////////////////////
//////////////////////////////////////////////// UNIVERSAL SHELLS AND OTHER DEBRIS ////////////////////////////////////////////////
////////////////////////////////////////////////                                   ////////////////////////////////////////////////

datablock DebrisData(ImpactFragmentDebris)
{
	shapeFile 			= "./Debris/frag.dts";
	lifetime 			= 2.8;
	spinSpeed			= 1200.0;
	minSpinSpeed 		= -3600.0;
	maxSpinSpeed 		= 3600.0;
	elasticity 			= 0.5;
	friction 			= 0.2;
	numBounces 			= 3;
	staticOnMaxBounce 	= true;
	snapOnMaxBounce 	= false;
	fade 				= true;
	gravModifier 		= 4;
};

////////////////////////////////////////////////                      ////////////////////////////////////////////////
//////////////////////////////////////////////// UNIVERSAL EXPLOSIONS ////////////////////////////////////////////////
////////////////////////////////////////////////                      ////////////////////////////////////////////////

// SCREENSHAKE STUFF EXPLOSION

datablock ExplosionData(AEMissGunExplosion)
{ 
  lifeTimeMS = 50;
	particleEmitter = GenericExplosionEmitter;
	particleDensity = 5;
	particleRadius = 0.2;
  emitter[1] = gc_bulletDebrisExplosionEmitter;
  faceViewer = true;
  explosionScale = "1 1 1";
  shakeCamera = true;
  camShakeFreq = "5 5 5";
  camShakeAmp = "1 1 1";
  camShakeDuration = 0.5;
  camShakeRadius = 1;
  soundProfile = "";
};

datablock ExplosionData(AEHitGunExplosion)
{ 
   lifeTimeMS = 50;
   emitter[0] = AEExplosionRingEmitter;
   faceViewer = true;
   explosionScale = "1 1 1";
   shakeCamera = true;
   camShakeFreq = "5 5 5";
   camShakeAmp = "1 1 1";
   camShakeDuration = 0.5;
   camShakeRadius = 1;
   soundProfile = "";
};

////////////////////////////////////////////////                        ////////////////////////////////////////////////
//////////////////////////////////////////////// UNIVERSAL PLAYERTYPES? ////////////////////////////////////////////////
////////////////////////////////////////////////                        ////////////////////////////////////////////////

// PLAYERTYPES (taken from swollow's weapons)

datablock PlayerData(emptyPlayer : playerStandardArmor)
{
	shapeFile = "base/data/shapes/empty.dts";
	boundingBox = "0.01 0.01 0.01";
	crouchboundingBox = "0.01 0.01 0.01";
	deathSound = "";
	painSound = "";
	useCustomPainEffects = true;
	mountSound = "";
	jumpSound = "";
	uiName = "";
}; 

// i know i broke the format but the effects dont want to load for some reason so i gotta put this here

datablock AudioProfile(BKTBulletSound)
{
   filename    = "./Sounds/Generic/bulletwhiz.wav";
   description = AudioClosest3d;
   preload = true;
};

datablock ProjectileData(AETrailedProjectile)
{
    projectileShapeName = "base/data/shapes/empty.dts";
    directDamage        = 50;
    directDamageType    = $DamageType::AE;
    radiusDamageType    = $DamageType::AE;

    brickExplosionRadius = 0;
    brickExplosionImpact = true;          //destroy a brick if we hit it directly?
    brickExplosionForce  = 10;
    brickExplosionMaxVolume = 1;          //max volume of bricks that we can destroy
    brickExplosionMaxVolumeFloating = 2;  //max volume of bricks that we can destroy if they aren't connected to the ground

    impactImpulse         = 50; //150
    verticalImpulse     = 50;
    explosion           = AEMissGunExplosion;
    bloodExplosion      = AEHitGunExplosion;

    muzzleVelocity      = 50;
    velInheritFactor    = 0;

    armingDelay         = 0;
    lifetime            = 6000;
    fadeDelay           = 5900;
    bounceElasticity    = 0.5;
    bounceFriction      = 0.20;
    isBallistic         = true;
    gravityMod = 0.5;

    particleEmitter     = AERifleTrailEmitter;

    hasLight    = false;
    lightRadius = 3.0;
    lightColor  = "0 0 0.5";
};

function AETrailedProjectile::onCollision(%this, %obj, %col, %fade, %pos, %normal, %velocity)
{
	%damage = %obj.directDamage;
	%fallStart = %obj.falloffStart;
	%fallEnd = %obj.falloffEnd;
	%fallDmg = %obj.falloffDamage;

	if(%fallStart $= "") %fallStart = 0;
	if(%fallEnd $= "") %fallEnd = 128;
	if(%fallDmg $= "") %fallDmg = 1;

	if(!$Pref::AEBase::damageRampUp && %fallDmg > 1)
		%fallDmg = 1;

	%dist = vectorDist(%obj.sourcePosition, %pos);
	%realEnd = mClampF(%fallEnd - %fallStart, 0, %fallEnd);
	%mult = 1 - (mClampF(%dist - %fallStart, 0, %realEnd) / %realEnd);
	%damage *= mFloatLerp(1, %fallDmg, %mult);
	
	%dmg = %this.directDamage;
	%this.directDamage = %damage;

	Parent::onCollision(%this, %obj, %col, %fade, %pos, %normal, %velocity);
	
	%this.directDamage = %dmg;

	if(!isObject(%col))
		return;

	%cn = %col.getClassName();
	if(%cn !$= "Player" && %cn !$= "AIPlayer")
	{
		if(getRandom() > 0.75)
			serverPlay3D(BulletImpact @ getRandom(1,4) @ Sound, %pos);
	}
}

function AETrailedProjectile::Damage(%this, %obj, %col, %fade, %pos, %normal)
{
	if(!isObject(%col))
		return;

	%damage = %obj.directDamage;
	%headshot = (ae_calculateDamagePosition(%col, %pos) $= "head");

	if(%obj.headshotMult == 0)
		%obj.headshotMult = 1;

	if(%col.IsA("WheeledVehicle") || %col.IsA("FlyingVehicle"))
	{
		%damage *= %obj.vehicleDamage;
		%isVehicle = true;
	}
	
	if(!%isVehicle)
	{
		if (%headshot)
		{
			if ($Pref::AEBase::bloodsound $= true)
			{
				if(getSimTime() - %col.lastImpactSound > 300)
				{
					serverPlay3D(AEHeadshot @ getRandom(1,3) @ Sound, %pos);
					%col.lastImpactSound = getSimTime();
				}
			}
			%col.playThread(2 , jump);
			%col.schedule(50, "playThread", "2", "plant");        
			%damage *= %obj.headshotMult;
		}
		else
		{
			if ($Pref::AEBase::bloodsound $= true)
			{
				if(getSimTime() - %col.lastImpactSound > 300)
				{
					serverPlay3D(AEBodyshot @ getRandom(1,3) @ Sound, %pos);
					%col.lastImpactSound = getSimTime();
				}
			}
			%col.playThread(2 , plant);        
		}
	}

	if((%type = %obj.directDamageType) $= "")
		%type = %this.directDamageType;
	
	if(%headshot)
	{
		if((%type2 = %obj.directHeadDamageType) $= "" && (%type2 = %this.directHeadDamageType) $= "")
			%type2 = %type;
	}

	if(%type2 !$= "")
		%type = %type2;
	
	if(%obj.RGibExplosionBody && !%headshot || %obj.RGibExplosionHead && %headshot)
	{
		%col.markForGibExplosion = true;
		%col.markForGibExplosionTime = getSimTime();
	}

	%fallStart = %obj.falloffStart;
	%fallEnd = %obj.falloffEnd;
	%fallDmg = %obj.falloffDamage;

	if(%fallStart $= "") %fallStart = 0;
	if(%fallEnd $= "") %fallEnd = 128;
	if(%fallDmg $= "") %fallDmg = 1;

	if(!$Pref::AEBase::damageRampUp && %fallDmg > 1)
		%fallDmg = 1;

	%dist = vectorDist(%obj.sourcePosition, %pos);
	%realEnd = mClampF(%fallEnd - %fallStart, 0, %fallEnd);
	%mult = 1 - (mClampF(%dist - %fallStart, 0, %realEnd) / %realEnd);
	%damage *= mFloatLerp(1, %fallDmg, %mult);

	%dmg = %this.directDamage;
	%this.directDamage = %damage;

	%dism = %damage >= $Pref::RBloodMod::DismemberDamage || (%obj.RDismemberBody && !%headshot || %obj.RDismemberHead && %headshot);

//	if(isFunction("Player", RBloodSimulate) && (%col.IsA("Player") || %col.IsA("AIPlayer")))
//		%col.RBloodSimulate(%pos, vectorNormalize(%obj.getVelocity()), %this, %obj.getScale(), %dism);

	//%col.damage(%obj, %pos, %damage, %type);
	Parent::Damage(%this, %obj, %col, %fade, %pos, %normal);

	//talk(%col SPC %damage SPC %col.getClassName() SPC %col.getDamageLevel());
	
	%this.directDamage = %dmg;

	if((%str = %obj.tagStrength) $= "")
		%str = %this.tagStrength;

	if((%rec = %obj.tagRecover) $= "")
		%rec = %this.tagRecover;
	
	if(%str > 0 && %rec > 0 && !%isVehicle)
		%col.aeTagHit(%str, %rec);
}

// non tracer projectile

datablock ProjectileData(AEProjectile : AETrailedProjectile)
{
  particleEmitter     = AESilencedTrailEmitter;
};

function AEProjectile::onCollision(%this, %obj, %col, %fade, %pos, %normal, %velocity)
{
	AETrailedProjectile::onCollision(%this, %obj, %col, %fade, %pos, %normal, %velocity);
}

function AEProjectile::Damage(%this, %obj, %col, %fade, %pos, %normal)
{
	AETrailedProjectile::Damage(%this, %obj, %col, %fade, %pos, %normal);
}

// science projectile

datablock ProjectileData(AETraillessProjectile : AETrailedProjectile)
{
  particleEmitter = "";
  bulletHolesEnabled = true;
};

function AETraillessProjectile::onCollision(%this, %obj, %col, %fade, %pos, %normal, %velocity)
{
	AETrailedProjectile::onCollision(%this, %obj, %col, %fade, %pos, %normal, %velocity);
}

function AETraillessProjectile::Damage(%this, %obj, %col, %fade, %pos, %normal)
{
	AETrailedProjectile::Damage(%this, %obj, %col, %fade, %pos, %normal);
}

// shotgun concussion blast

datablock ProjectileData(ShotgunBlastProjectile : AETrailedProjectile)
{
   projectileShapeName = "add-ons/Vehicle_Tank/tankbullet.dts";
   particleEmitter = "";
  
   muzzleVelocity      = 100;
   impactImpulse	     = 300;
   verticalImpulse     = 100;

   armingDelay         = 0;
   lifetime            = 70;
   fadeDelay           = 0;
   isBallistic         = true;
   gravityMod = 0.0;
};

function ShotgunBlastProjectile::onCollision(%this, %obj, %col, %fade, %pos, %normal, %velocity)
{
	AETrailedProjectile::onCollision(%this, %obj, %col, %fade, %pos, %normal, %velocity);
}

function ShotgunBlastProjectile::Damage(%this, %obj, %col, %fade, %pos, %normal)
{
	AETrailedProjectile::Damage(%this, %obj, %col, %fade, %pos, %normal);
}

// HITSCAN TRACER

datablock StaticShapeData(BulletTrailStatic) { shapeFile = "./Hitscan/bullettrail.dts"; };

function BulletTrailStatic::onAdd(%this,%obj)
{
  %obj.playThread(2,root);
  %obj.schedule(100,delete);
}

// LASER DOT

datablock StaticShapeData(AELaserDotShape)
{
	shapeFile = "./laserdot.dts";
};

// FLASHLIGHT

datablock FxLightData(AEPlayerFlashlight : PlayerLight) {
	uiName = "";
	flareOn = 0;

	radius = 16;
	brightness = 3;
};

// MUZZLE FLASH

// GENERIC

datablock ParticleData(AEBaseGenericFlashParticle)
{
  dragCoefficient = 0;
  inheritedVelFactor = 1;
  lifetimeMS = 35;
  textureName = "./Particles/genericflash2";
  spinSpeed = 5000;
  spinRandomMin = -5000;
  spinRandomMax = 5000;
  colors[0]     = "1 0.6 0.5 1";
  colors[1]     = "0.9 0.4 0.3 1";
  colors[2]     = "0.9 0.4 0.3 0.1";
  sizes[0] = 0.25;
  sizes[1] = 1;
  sizes[2] = 0.25;
  times[9] = 0;
  times[1] = 0.3;
  times[2] = 1;
  useInvAlpha = false;
};

datablock ParticleEmitterData(AEBaseGenericFlashEmitter)
{
  ejectionPeriodMS = 3;
  ejectionVelocity = 50;
  velocityVariance = 0;
  thetaMin = 0;
  thetaMax = 10;
  phiReferenceVel = 0;
  phiVariance = 360;
  particles = "AEBaseGenericFlashParticle";
  uiName = "";
};

// RIFLE

datablock ParticleData(AEBaseRifleFlashParticle)
{
  dragCoefficient = 0;
  inheritedVelFactor = 1;
  lifetimeMS = 35;
  textureName = "./Particles/rifleflash2";
  spinSpeed = 5000;
  spinRandomMin = -5000;
  spinRandomMax = 5000;
  colors[0]     = "1 0.6 0.5 1";
  colors[1]     = "0.9 0.4 0.3 1";
  colors[2]     = "0.9 0.4 0.3 0.1";
  sizes[0] = 0.075;
  sizes[1] = 1.5;
  sizes[2] = 0.75;
  times[9] = 0;
  times[1] = 0.3;
  times[2] = 1;
  useInvAlpha = false;
};

datablock ParticleEmitterData(AEBaseRifleFlashEmitter)
{
  ejectionPeriodMS = 3;
  ejectionVelocity = 50;
  velocityVariance = 0;
  thetaMin = 0;
  thetaMax = 10;
  phiReferenceVel = 0;
  phiVariance = 360;
  particles = "AEBaseRifleFlashParticle";
  uiName = "";
};

// SHOTGUN

datablock ParticleData(AEBaseShotgunFlashParticle)
{
  dragCoefficient = 0;
  inheritedVelFactor = 1;
  lifetimeMS = 35;
  textureName = "./Particles/genericflash2";
  spinSpeed = 5000;
  spinRandomMin = -5000;
  spinRandomMax = 5000;
  colors[0]     = "1 0.6 0.5 1";
  colors[1]     = "0.9 0.4 0.3 1";
  colors[2]     = "0.9 0.4 0.3 0.1";
  sizes[0] = 0.5;
  sizes[1] = 2;
  sizes[2] = 0.5;
  times[9] = 0;
  times[1] = 0.3;
  times[2] = 1;
  useInvAlpha = false;
};

datablock ParticleEmitterData(AEBaseShotgunFlashEmitter)
{
  ejectionPeriodMS = 3;
  ejectionVelocity = 50;
  velocityVariance = 0;
  thetaMin = 0;
  thetaMax = 10;
  phiReferenceVel = 0;
  phiVariance = 360;
  particles = "AEBaseShotgunFlashParticle";
  uiName = "";
};



// SMOKE STUFF

datablock ParticleData(AEBaseSmokeParticle)
{
	dragCoefficient      = 10;
	gravityCoefficient   = 0.0;
	inheritedVelFactor   = 0.2;
	constantAcceleration = 0.0;
	lifetimeMS           = 500;
	lifetimeVarianceMS   = 55;
	spinSpeed		= 10.0;
	spinRandomMin		= -100.0;
	spinRandomMax		= 100.0;
	//Relevant stuff:
	textureName		= "./cloud"; //This automatically gets replaced with animTexName[0]
	animTexName[0]	= "./Particles/codsmoke1";
	animTexName[1]	= "./Particles/codsmoke2";
	animTexName[2]	= "./Particles/codsmoke3";
	animTexName[3]	= "./Particles/codsmoke4";
	animTexName[4]	= "./Particles/codsmoke5";
	animTexName[5]	= "./Particles/codsmoke6";
	animTexName[6]	= "./Particles/codsmoke7";
	animTexName[7]	= "./Particles/codsmoke8";
	animTexName[8]	= "./Particles/codsmoke9";
	animTexName[9]	= "./Particles/codsmoke10";
	animTexName[10]	= "./Particles/codsmoke11";
	animTexName[11]	= "./Particles/codsmoke12";
	animateTexture	= true;
	framesPerSec	= 20;
	numFrames		= 12; //This variable does not seem to function. It is documented in the Torque guide, but number of frames seems to be detected automatically.
	colors[0]     = "1 1 1 0.2";
	colors[1]     = "1 1 1 0.0";
	sizes[0]      = 1;
	sizes[1]      = 3;

	useInvAlpha = true;
};

//bullshit downloader stuff dont laugh at me i just want based animated smoke =(
datablock ParticleData(CodSmoke2TextureDownloader : AEBaseSmokeParticle)
{
    textureName = "./Particles/codsmoke2.png";
};
datablock ParticleData(CodSmoke3TextureDownloader : AEBaseSmokeParticle)
{
    textureName = "./Particles/codsmoke3.png";
};
datablock ParticleData(CodSmoke4TextureDownloader : AEBaseSmokeParticle)
{
    textureName = "./Particles/codsmoke4.png";
};
datablock ParticleData(CodSmoke5TextureDownloader : AEBaseSmokeParticle)
{
    textureName = "./Particles/codsmoke5.png";
};
datablock ParticleData(CodSmoke6TextureDownloader : AEBaseSmokeParticle)
{
    textureName = "./Particles/codsmoke6.png";
};
datablock ParticleData(CodSmoke7TextureDownloader : AEBaseSmokeParticle)
{
    textureName = "./Particles/codsmoke7.png";
};
datablock ParticleData(CodSmoke8TextureDownloader : AEBaseSmokeParticle)
{
    textureName = "./Particles/codsmoke8.png";
};
datablock ParticleData(CodSmoke9TextureDownloader : AEBaseSmokeParticle)
{
    textureName = "./Particles/codsmoke9.png";
};
datablock ParticleData(CodSmoke10TextureDownloader : AEBaseSmokeParticle)
{
    textureName = "./Particles/codsmoke10.png";
};
datablock ParticleData(CodSmoke11TextureDownloader : AEBaseSmokeParticle)
{
    textureName = "./Particles/codsmoke11.png";
};
datablock ParticleData(CodSmoke12TextureDownloader : AEBaseSmokeParticle)
{
    textureName = "./Particles/codsmoke12.png";
};
// end of cringe 

datablock ParticleEmitterData(AEBaseSmokeEmitter)
{
   ejectionPeriodMS = 50;
   periodVarianceMS = 0;
   ejectionVelocity = 12.0;
   velocityVariance = 0.1;
   ejectionOffset   = 0;
   thetaMin         = 0;
   thetaMax         = 15;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   particles = "AEBaseSmokeParticle";
   isLooping = false;

   uiName = "";
};

datablock ParticleData(AEBaseSmokeBigParticle : AEBaseSmokeParticle)
{
	sizes[0]      = 2;
	sizes[1]      = 8;
};

datablock ParticleEmitterData(AEBaseSmokeBigEmitter : AEBaseSmokeEmitter)
{
   particles = "AEBaseSmokeBigParticle";
};

datablock ParticleData(ShellSmokeParticle)
{
	dragCoefficient      = 10;
	gravityCoefficient   = 0.0;
	inheritedVelFactor   = 0.2;
	constantAcceleration = 0.0;
	lifetimeMS           = 500;
	lifetimeVarianceMS   = 55;
	spinSpeed		= 10.0;
	spinRandomMin		= -100.0;
	spinRandomMax		= 100.0;
	//Relevant stuff:
	textureName		= "./cloud"; //This automatically gets replaced with animTexName[0]
	animTexName[0]	= "./Particles/codsmoke1";
	animTexName[1]	= "./Particles/codsmoke2";
	animTexName[2]	= "./Particles/codsmoke3";
	animTexName[3]	= "./Particles/codsmoke4";
	animTexName[4]	= "./Particles/codsmoke5";
	animTexName[5]	= "./Particles/codsmoke6";
	animTexName[6]	= "./Particles/codsmoke7";
	animTexName[7]	= "./Particles/codsmoke8";
	animTexName[8]	= "./Particles/codsmoke9";
	animTexName[9]	= "./Particles/codsmoke10";
	animTexName[10]	= "./Particles/codsmoke11";
	animTexName[11]	= "./Particles/codsmoke12";
	animateTexture	= true;
	framesPerSec	= 20;
	numFrames		= 12; //This variable does not seem to function. It is documented in the Torque guide, but number of frames seems to be detected automatically.
	colors[0]     = "1 1 1 0.2";
	colors[1]     = "1 1 1 0";
	sizes[0]      = 0.5;
	sizes[1]      = 1.15;

	useInvAlpha = true;
};

datablock ParticleEmitterData(ShellSmokeEmitter)
{
   lifetimeMS = 25;
   ejectionPeriodMS = 25;
   periodVarianceMS = 0;
   ejectionVelocity = 1.0;
   velocityVariance = 0.1;
   ejectionOffset   = 0.0;
   thetaMin         = 0;
   thetaMax         = 15;
   phiReferenceVel  = 0;
   phiVariance      = 360;
   overrideAdvance = false;
   particles = "ShellSmokeParticle";

   uiName = "";
};

datablock ParticleData(ShellSmokeBigParticle : ShellSmokeParticle)
{
	sizes[0]      = 1;
	sizes[1]      = 2;	
};

datablock ParticleEmitterData(ShellSmokeBigEmitter : ShellSmokeEmitter)
{
   particles = "ShellSmokeBigParticle";
};

// SHELLS

datablock DebrisData(AEPistolShellDebris : GunShellDebris)
{
	emitters = ShellSmokeEmitter;

	shapeFile = "./Debris/pistol_shell.dts";
	lifetime = 2;
	minSpinSpeed = 1000.0; 
	maxSpinSpeed = 2000.0;
	elasticity = 0.5;
	friction = 0;
	numBounces = 2;
	staticOnMaxBounce = true;
	snapOnMaxBounce = false;
	fade = true;

	gravModifier = 2;
};

datablock DebrisData(AERifleShellDebris : GunShellDebris)
{
	emitters = ShellSmokeEmitter;

	shapeFile = "./Debris/rifle_shell.dts";
	lifetime = 2;
	minSpinSpeed = 1000.0; 
	maxSpinSpeed = 2000.0;
	elasticity = 0.5;
	friction = 0;
	numBounces = 2;
	staticOnMaxBounce = true;
	snapOnMaxBounce = false;
	fade = true;

	gravModifier = 2;
};

datablock DebrisData(AEShotgunShellDebris : GunShellDebris)
{
	emitters = ShellSmokeEmitter;

	shapeFile = "./Debris/shotgun_shell.dts";
	lifetime = 2;
	minSpinSpeed = 1000.0; 
	maxSpinSpeed = 2000.0;
	elasticity = 0.5;
	friction = 0;
	numBounces = 2;
	staticOnMaxBounce = true;
	snapOnMaxBounce = false;
	fade = true;

	gravModifier = 2;
};

datablock DebrisData(AE_BEPistolShellDebris : AEPistolShellDebris)
{
	shapeFile = "./Debris/be_9mm_shell.dts";
};

datablock DebrisData(AE_BERifleShellDebris : AERifleShellDebris)
{
	shapeFile = "./Debris/be_556_shell.dts";
};

datablock DebrisData(AE_BELMGShellDebris : AERifleShellDebris)
{
	shapeFile = "./Debris/be_556chain_shell.dts";
};

datablock DebrisData(AE_BEFiftyShellDebris : AERifleShellDebris)
{
	emitters = ShellSmokeBigEmitter;
	shapeFile = "./Debris/be_50_shell.dts";
	gravModifier = 3;
};

datablock DebrisData(AE_BEHeavyShotgunDebris : AERifleShellDebris)
{
	emitters = ShellSmokeBigEmitter;
	shapeFile = "./Debris/be_4g_shell.dts";
	gravModifier = 3;
};

datablock DebrisData(AE_BEShotgunShellDebris : AEShotgunShellDebris)
{
	shapeFile = "./Debris/be_12g_shell.dts";
};

