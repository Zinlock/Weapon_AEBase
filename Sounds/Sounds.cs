// GENERIC DRAW

datablock AudioProfile(useSound)
{
   filename    = "./Generic/use.wav";
   description = AudioClosest3d;
   preload = true;
};

// LOOPING FIRE

datablock AudioDescription(BAADFireLightLoop3D : AudioClose3d)
{
	volume   = 1.5;
   isLooping= true;
   is3D     = true;
   ReferenceDistance= 20.0;
   MaxDistance= 120.0;
};

datablock AudioDescription(BAADFireMediumLoop3D : AudioClose3d)
{
	volume   = 1.5;
   isLooping= true;
   is3D     = true;
   ReferenceDistance= 25.0;
   MaxDistance= 120.0;
};

datablock AudioDescription(BAADFireHeavyLoop3D : AudioClose3d)
{
	volume   = 1.5;
   isLooping= true;
   is3D     = true;
   ReferenceDistance= 26.0;
   MaxDistance= 120.0;
};

// DISTANT SHOT

datablock AudioDescription(LightClose3D: AudioClose3d)
{
	volume   = 1;
   isLooping= false;
   is3D     = true;
   ReferenceDistance= 20.0;
   MaxDistance= 120.0;
};
datablock AudioDescription(MediumClose3D: AudioClose3d)
{
	volume   = 1;
   isLooping= false;
   is3D     = true;
   ReferenceDistance= 25.0;
   MaxDistance= 120.0;
};
datablock AudioDescription(HeavyClose3D: AudioClose3d)
{
	volume   = 1;
   isLooping= false;
   is3D     = true;
   ReferenceDistance= 26.0;
   MaxDistance= 120.0;
};
datablock AudioDescription(ExplosionClose3D: AudioClose3d)
{
	volume   = 1;
   isLooping= false;
   is3D     = true;
   ReferenceDistance= 100.0;
   MaxDistance= 150.0;
};
datablock AudioDescription(LightFar3D: AudioClose3d)
{
	volume   = 0.25;
   isLooping= false;
   is3D     = true;
   ReferenceDistance= 120.0;
   MaxDistance= 420.0;
};
datablock AudioDescription(MediumFar3D: AudioClose3d)
{
	volume   = 0.25;
   isLooping= false;
   is3D     = true;
   ReferenceDistance= 120.0;
   MaxDistance= 600.0;
};
datablock AudioDescription(HeavyFar3D: AudioClose3d)
{
	volume   = 0.25;
   isLooping= false;
   is3D     = true;
   ReferenceDistance= 120.0;
   MaxDistance= 840.0;
};
datablock AudioDescription(ExplosionFar3D: AudioClose3d)
{
	volume   = 0.25;
   isLooping= false;
   is3D     = true;
   ReferenceDistance= 500.0;
   MaxDistance= 1000.0;
};

// smg distant

datablock AudioProfile(SMGADistantSound)
{
   filename    = "./Generic/Distant/SMGADistant.wav";
   description = LightFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(SMGBDistantSound)
{
   filename    = "./Generic/Distant/SMGBDistant.wav";
   description = LightFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(SMGCDistantSound)
{
   filename    = "./Generic/Distant/SMGCDistant.wav";
   description = LightFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(SMGDDistantSound)
{
   filename    = "./Generic/Distant/SMGDDistant.wav";
   description = LightFar3D;
   pitchRange = 25;
   preload = true;
};

// pistol distant

datablock AudioProfile(PistolADistantSound)
{
   filename    = "./Generic/Distant/PistolADistant.wav";
   description = LightFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(PistolBDistantSound)
{
   filename    = "./Generic/Distant/PistolBDistant.wav";
   description = LightFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(PistolCDistantSound)
{
   filename    = "./Generic/Distant/PistolCDistant.wav";
   description = LightFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(PistolDDistantSound)
{
   filename    = "./Generic/Distant/PistolDDistant.wav";
   description = LightFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(PistolEDistantSound)
{
   filename    = "./Generic/Distant/PistolEDistant.wav";
   description = LightFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(PistolFDistantSound)
{
   filename    = "./Generic/Distant/PistolFDistant.wav";
   description = LightFar3D;
   pitchRange = 25;
   preload = true;
};

// rifle distant

datablock AudioProfile(RifleADistantSound)
{
   filename    = "./Generic/Distant/RifleADistant.wav";
   description = MediumFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(RifleBDistantSound)
{
   filename    = "./Generic/Distant/RifleBDistant.wav";
   description = MediumFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(RifleCDistantSound)
{
   filename    = "./Generic/Distant/RifleCDistant.wav";
   description = MediumFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(RifleDDistantSound)
{
   filename    = "./Generic/Distant/RifleDDistant.wav";
   description = MediumFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(RifleEDistantSound)
{
   filename    = "./Generic/Distant/RifleEDistant.wav";
   description = MediumFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(RifleFDistantSound)
{
   filename    = "./Generic/Distant/RifleFDistant.wav";
   description = MediumFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(RifleGDistantSound)
{
   filename    = "./Generic/Distant/RifleGDistant.wav";
   description = MediumFar3D;
   pitchRange = 25;
   preload = true;
};

// Shotty distant

datablock AudioProfile(ShottyADistantSound)
{
   filename    = "./Generic/Distant/ShottyADistant.wav";
   description = HeavyFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(ShottyBDistantSound)
{
   filename    = "./Generic/Distant/ShottyBDistant.wav";
   description = HeavyFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(ShottyCDistantSound)
{
   filename    = "./Generic/Distant/ShottyCDistant.wav";
   description = HeavyFar3D;
   pitchRange = 25;
   preload = true;
};

// Sniper distant

datablock AudioProfile(SniperADistantSound)
{
   filename    = "./Generic/Distant/SniperADistant.wav";
   description = HeavyFar3D;
   pitchRange = 15;
   preload = true;
};

datablock AudioProfile(SniperBDistantSound)
{
   filename    = "./Generic/Distant/SniperBDistant.wav";
   description = HeavyFar3D;
   pitchRange = 15;
   preload = true;
};

datablock AudioProfile(SniperCDistantSound)
{
   filename    = "./Generic/Distant/SniperCDistant.wav";
   description = HeavyFar3D;
   pitchRange = 15;
   preload = true;
};

// extras distant

datablock AudioProfile(PistolHeavyDistantSound)
{
   filename    = "./Generic/Distant/PistolHeavyDistant.wav";
   description = MediumFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(RevolverDistantSound)
{
   filename    = "./Generic/Distant/RevolverDistant.wav";
   description = MediumFar3D;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(ExplosionLightDistantSound)
{
   filename    = "./Generic/Distant/ExplosionLightDistant.wav";
   description = ExplosionFar3D;
   pitchRange = 25;
   preload = true;
};

// END OF DISTANT SOUND SHENANIGANS

// BodySHOTS

datablock AudioProfile(AEBodyshot1Sound)
{
   filename    = "./Generic/AEBodyshot1.wav";
   description = AudioClosest3d;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(AEBodyshot2Sound)
{
   filename    = "./Generic/AEBodyshot2.wav";
   description = AudioClosest3d;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(AEBodyshot3Sound)
{
   filename    = "./Generic/AEBodyshot3.wav";
   description = AudioClosest3d;
   pitchRange = 25;
   preload = true;
};

// HEADSHOTS

datablock AudioProfile(AEHeadshot1Sound)
{
   filename    = "./Generic/AEHeadshot1.wav";
   description = AudioClosest3d;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(AEHeadshot2Sound)
{
   filename    = "./Generic/AEHeadshot2.wav";
   description = AudioClosest3d;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(AEHeadshot3Sound)
{
   filename    = "./Generic/AEHeadshot3.wav";
   description = AudioClosest3d;
   pitchRange = 25;
   preload = true;
};

// RALLY IMPACT SOUNDS

datablock AudioProfile(RallyImpact1Sound)
{
   filename    = "./Generic/RallyImpact1.wav";
   description = AudioClosest3d;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(RallyImpact2Sound)
{
   filename    = "./Generic/RallyImpact2.wav";
   description = AudioClosest3d;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(RallyImpact3Sound)
{
   filename    = "./Generic/RallyImpact3.wav";
   description = AudioClosest3d;
   pitchRange = 25;
   preload = true;
};

datablock AudioProfile(RallyImpact4Sound)
{
   filename    = "./Generic/RallyImpact4.wav";
   description = AudioClosest3d;
   pitchRange = 25;
   preload = true;
};

// SHELLS

datablock AudioProfile(AEShellRifle1Sound)
{
	filename    = "./Physics/shell_bounce_lg01.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};
datablock AudioProfile(AEShellRifle2Sound)
{
	filename    = "./Physics/shell_bounce_lg02.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};
datablock AudioProfile(AEShellRifle3Sound)
{
	filename    = "./Physics/shell_bounce_lg03.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

datablock AudioProfile(AEShellSMG1Sound)
{
	filename    = "./Physics/shell_bounce_sm01.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};
datablock AudioProfile(AEShellSMG2Sound)
{
	filename    = "./Physics/shell_bounce_sm02.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};
datablock AudioProfile(AEShellSMG3Sound)
{
	filename    = "./Physics/shell_bounce_sm03.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

datablock AudioProfile(AEShellShotgun1Sound)
{
	filename    = "./Physics/shell_bounce_sg01.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};
datablock AudioProfile(AEShellShotgun2Sound)
{
	filename    = "./Physics/shell_bounce_sg02.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};
datablock AudioProfile(AEShellShotgun3Sound)
{
	filename    = "./Physics/shell_bounce_sg03.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

datablock AudioProfile(AEShellSniper1Sound)
{
	filename    = "./Physics/shell_bounce_sn01.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};
datablock AudioProfile(AEShellSniper2Sound)
{
	filename    = "./Physics/shell_bounce_sn02.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};
datablock AudioProfile(AEShellSniper3Sound)
{
	filename    = "./Physics/shell_bounce_sn03.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

datablock AudioProfile(AEShellHeavyShotgun1Sound)
{
	filename    = "./Physics/shell_bounce_hsg01.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};
datablock AudioProfile(AEShellHeavyShotgun2Sound)
{
	filename    = "./Physics/shell_bounce_hsg02.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};
datablock AudioProfile(AEShellHeavyShotgun3Sound)
{
	filename    = "./Physics/shell_bounce_hsg02.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

// MAG DROP

// drum
datablock AudioProfile(AEMagDrum1Sound)
{
	filename    = "./Physics/MAGDRUM1.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};
datablock AudioProfile(AEMagDrum2Sound)
{
	filename    = "./Physics/MAGDRUM2.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

datablock AudioProfile(AEMagDrum3Sound)
{
	filename    = "./Physics/MAGDRUM3.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

// mag metal ar
datablock AudioProfile(AEMagMetalAR1Sound)
{
	filename    = "./Physics/MAGMETALAR1.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

datablock AudioProfile(AEMagMetalAR2Sound)
{
	filename    = "./Physics/MAGMETALAR2.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

datablock AudioProfile(AEMagMetalAR3Sound)
{
	filename    = "./Physics/MAGMETALAR3.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

// mag pistol
datablock AudioProfile(AEMagPistol1Sound)
{
	filename    = "./Physics/MAGPISTOL1.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

datablock AudioProfile(AEMagPistol2Sound)
{
	filename    = "./Physics/MAGPISTOL2.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

datablock AudioProfile(AEMagPistol3Sound)
{
	filename    = "./Physics/MAGPISTOL3.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

// mag plastic ar
datablock AudioProfile(AEMagPlasticAR1Sound)
{
	filename    = "./Physics/MAGPLASTICAR1.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

datablock AudioProfile(AEMagPlasticAR2Sound)
{
	filename    = "./Physics/MAGPLASTICAR2.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

datablock AudioProfile(AEMagPlasticAR3Sound)
{
	filename    = "./Physics/MAGPLASTICAR3.wav";
	description = AudioClosest3d;
    pitchRange = 10;
	preload = true;
};

// ADS IN

datablock AudioProfile(AEAdsIn1Sound)
{
	filename    = "./Generic/ads_in1.wav";
	description = AudioClosest3d;
	pitchRange = 7;
	preload = true;
};

datablock AudioProfile(AEAdsIn3Sound)
{
	filename    = "./Generic/ads_in3.wav";
	description = AudioClosest3d;
	pitchRange = 7;
	preload = true;
};

datablock AudioProfile(AEAdsIn5Sound)
{
	filename    = "./Generic/ads_in5.wav";
	description = AudioClosest3d;
	pitchRange = 7;
	preload = true;
};

datablock AudioProfile(AEAdsIn6Sound)
{
	filename    = "./Generic/ads_in6.wav";
	description = AudioClosest3d;
	pitchRange = 7;
	preload = true;
};

// ADS OUT

datablock AudioProfile(AEAdsOut1Sound)
{
	filename    = "./Generic/ads_out1.wav";
	description = AudioClosest3d;
	pitchRange = 7;
	preload = true;
};

datablock AudioProfile(AEAdsOut3Sound)
{
	filename    = "./Generic/ads_out3.wav";
	description = AudioClosest3d;
	pitchRange = 7;
	preload = true;
};

// AMMO PICKUP

datablock AudioProfile(AEAmmoPickupSound)
{
   filename    = "./Generic/AmmoPickup.wav";
   description = AudioClosest3d;
   preload = true;

	 pitchRange = 15;
};

// DRY FIRE

datablock AudioProfile(AEDryFireSound)
{
   filename    = "./Generic/Dryfire.wav";
   description = AudioClosest3d;
   preload = true;

	 pitchRange = 15;
};

// ITEM PHYSICS NOISE SOFT

datablock AudioProfile(AEWepImpactSoft1Sound)
{
   filename    = "./Physics/weapon_impact_soft1.wav";
   description = AudioClosest3d;
   preload = true;

	 pitchRange = 5;
};

datablock AudioProfile(AEWepImpactSoft2Sound)
{
   filename    = "./Physics/weapon_impact_soft2.wav";
   description = AudioClosest3d;
   preload = true;

	 pitchRange = 5;
};

datablock AudioProfile(AEWepImpactSoft3Sound)
{
   filename    = "./Physics/weapon_impact_soft3.wav";
   description = AudioClosest3d;
   preload = true;

	 pitchRange = 5;
};

// ITEM PHYSICS NOISE HARD

datablock AudioProfile(AEWepImpactHard1Sound)
{
   filename    = "./Physics/weapon_impact_hard1.wav";
   description = AudioClosest3d;
   preload = true;

	 pitchRange = 5;
};

datablock AudioProfile(AEWepImpactHard2Sound)
{
   filename    = "./Physics/weapon_impact_hard2.wav";
   description = AudioClosest3d;
   preload = true;

	 pitchRange = 5;
};

datablock AudioProfile(AEWepImpactHard3Sound)
{
   filename    = "./Physics/weapon_impact_hard3.wav";
   description = AudioClosest3d;
   preload = true;

	 pitchRange = 5;
};

// FLY BY

datablock AudioProfile(AESubsonicWhizz1Sound)
{
   filename    = "./Suppression/subsonic_whizz1.wav";
   description = AudioClosest3d;
   preload = true;

	 pitchRange = 10;
};

datablock AudioProfile(AESubsonicWhizz2Sound : AESubsonicWhizz1Sound) {filename = "./Suppression/subsonic_whizz2.wav";};
datablock AudioProfile(AESubsonicWhizz3Sound : AESubsonicWhizz1Sound) {filename = "./Suppression/subsonic_whizz3.wav";};
datablock AudioProfile(AESubsonicWhizz4Sound : AESubsonicWhizz1Sound) {filename = "./Suppression/subsonic_whizz4.wav";};

datablock AudioProfile(AESupersonicCrack1Sound : AESubsonicWhizz1Sound) {filename = "./Suppression/light_crack1.wav";};
datablock AudioProfile(AESupersonicCrack2Sound : AESubsonicWhizz1Sound) {filename = "./Suppression/light_crack2.wav";};
datablock AudioProfile(AESupersonicCrack3Sound : AESubsonicWhizz1Sound) {filename = "./Suppression/light_crack3.wav";};
datablock AudioProfile(AESupersonicCrack4Sound : AESubsonicWhizz1Sound) {filename = "./Suppression/light_crack4.wav";};

datablock AudioProfile(AESupersonicBigCrack1Sound : AESubsonicWhizz1Sound) {filename = "./Suppression/supersonic_crack1.wav";};
datablock AudioProfile(AESupersonicBigCrack2Sound : AESubsonicWhizz1Sound) {filename = "./Suppression/supersonic_crack2.wav";};
datablock AudioProfile(AESupersonicBigCrack3Sound : AESubsonicWhizz1Sound) {filename = "./Suppression/supersonic_crack3.wav";};
datablock AudioProfile(AESupersonicBigCrack4Sound : AESubsonicWhizz1Sound) {filename = "./Suppression/supersonic_crack4.wav";};
