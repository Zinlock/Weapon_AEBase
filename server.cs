function AEBase_RegisterPrefs()
{
	if ($RTB::Hooks::ServerControl)
	{
		RTB_registerPref("Player Damage Multiplier", "AEBase - Player", "$Pref::AEBase::playerDamageMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Player Damage to Vehicle Multiplier", "AEBase - Player", "$Pref::AEBase::playerVehicleDamageMult", "int 0 50", "Weapon_AEBase", 0.25, false, false, "");
		RTB_registerPref("Player Headshot Multiplier", "AEBase - Player", "$Pref::AEBase::playerHeadshotMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Player Spread Multiplier", "AEBase - Player", "$Pref::AEBase::playerSpreadMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Player Sniper Hipfire Spread Multiplier", "AEBase - Player", "$Pref::AEBase::playerSniperHipfireSpreadMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Player Recoil Multiplier", "AEBase - Player", "$Pref::AEBase::playerRecoilMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Player Screenshake Multiplier", "AEBase - Player", "$Pref::AEBase::playerScreenshakeMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Player Tagging Strength Multiplier", "AEBase - Player", "$Pref::AEBase::playerTagMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Player Tagging Recovery Multiplier", "AEBase - Player", "$Pref::AEBase::playerTagRecoveryMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Spawn Player Projectiles As", "AEBase - Player", "$Pref::AEBase::projectilesAs","list ProjectilesOnly 0 HitscansOnly 1 ProjectilesHitscans 2 Any 3 ProjectilesHack 4", "Weapon_AEBase", 3, false, false, "");

		RTB_registerPref("Bot Damage Multiplier", "AEBase - Bot", "$Pref::AEBase::botDamageMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Bot Damage to Vehicle Multiplier", "AEBase - Bot", "$Pref::AEBase::botVehicleDamageMult", "int 0 50", "Weapon_AEBase", 0.25, false, false, "");
		RTB_registerPref("Bot Headshot Multiplier", "AEBase - Bot", "$Pref::AEBase::botHeadshotMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Bot Spread Multiplier", "AEBase - Bot", "$Pref::AEBase::botSpreadMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Bot Sniper Hipfire Spread Multiplier", "AEBase - Bot", "$Pref::AEBase::botSniperHipfireSpreadMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Bot Recoil Multiplier", "AEBase - Bot", "$Pref::AEBase::botRecoilMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Bot Tagging Strength Multiplier", "AEBase - Bot", "$Pref::AEBase::botTagMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Bot Tagging Recovery Multiplier", "AEBase - Bot", "$Pref::AEBase::botTagRecoveryMult", "int 0 50", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Spawn Bot Projectiles As", "AEBase - Bot", "$Pref::AEBase::projectilesAsBot", "list ProjectilesOnly 0 HitscansOnly 1 ProjectilesHitscans 2 Any 3 ProjectilesHack 4", "Weapon_AEBase", 3, false, false, "");

		RTB_registerPref("HUD Style","AEBase - HUD","$Pref::AEBase::HUD","list AEBase 0 T+T 1 Adventure_Pack 2 Rallypack 3 SWeps 4 GCats 5 Verbal 6 BKT 7 Blockality 8 Nekram 9 Tactical 10 None 11","Weapon_AEBase",0,0,1);
		RTB_registerPref("HUD Position","AEBase - HUD","$Pref::AEBase::HUDPos","list Bottom_Right 0 Bottom_Left 1 Bottom_Center 2 Center 3 Center_Right 4 Center_Left 5","Weapon_AEBase",0,0,1);

		RTB_registerPref("Blood Impact Sounds", "AEBase - Misc.", "$Pref::AEBase::bloodsound", "bool", "Weapon_AEBase", true, false, false, "");
		RTB_registerPref("Flashlight Blinding Multiplier", "AEBase - Misc.", "$Pref::AEBase::flashlightBlind", "int 0 2", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Laser Blinding Multiplier", "AEBase - Misc.", "$Pref::AEBase::laserBlind", "int 0 2", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Aim Down Sights", "AEBase - Misc.", "$Pref::AEBase::ads", "list All 0 Scoped 1 None 2", "Weapon_AEBase", 0, false, false, "");
		RTB_registerPref("Bullet Suppression", "AEBase - Misc.", "$Pref::AEBase::suppression", "bool", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Muzzle Flash Extra Glow Effect", "AEBase - Misc.", "$Pref::AEBase::muzzleFlash", "bool", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Enable Static Shape Tracers", "AEBase - Misc.", "$Pref::AEBase::staticTracers", "bool", "Weapon_AEBase", 1, false, false, "");

		RTB_registerPref("Ammo Pickup Sounds", "AEBase - Ammo", "$Pref::AEBase::ammosound", "bool", "Weapon_AEBase", true, false, false, "");
		RTB_registerPref("Ammo Pickup Messages", "AEBase - Ammo", "$Pref::AEBase::ammomessage", "bool", "Weapon_AEBase", true, false, false, "");
		RTB_registerPref("Spinning Ammo Items", "AEBase - Ammo", "$Pref::AEBase::ammoitemspin", "bool", "Weapon_AEBase", 1, false, false, "");
		RTB_registerPref("Enable Reserve Ammo", "AEBase - Ammo", "$Pref::AEBase::ReserveAmmo", "bool", "Weapon_AEBase", true, false, false, "");
		RTB_registerPref("Spawn With Reserve Ammo", "AEBase - Ammo", "$Pref::AEBase::FillReserveOnSpawn", "list None 0 Default 1 Full 2", "Weapon_AEBase",1,0,1);
		RTB_registerPref("Drop Ammo On Death", "AEBase - Ammo", "$Pref::AEBase::AmmoDeathDrop", "bool", "Weapon_AEBase",1,0,1);
	}
	else
	{
		if ($Pref::AEBase::playerDamageMult $= "") $Pref::AEBase::playerDamageMult = 1;
		if ($Pref::AEBase::playerVehicleDamageMult $= "") $Pref::AEBase::playerVehicleDamageMult = 0.25;
		if ($Pref::AEBase::playerHeadshotMult $= "") $Pref::AEBase::playerHeadshotMult = 1;
		if ($Pref::AEBase::playerSpreadMult $= "") $Pref::AEBase::playerSpreadMult = 1;
		if ($Pref::AEBase::playerSniperHipfireSpreadMult $= "") $Pref::AEBase::playerSniperHipfireSpreadMult = 1;
		if ($Pref::AEBase::playerRecoilMult $= "") $Pref::AEBase::playerRecoilMult = 1;
		if ($Pref::AEBase::playerScreenshakeMult $= "") $Pref::AEBase::playerScreenshakeMult = 1;
		if ($Pref::AEBase::playerTagMult $= "") $Pref::AEBase::playerTagMult = 1;
		if ($Pref::AEBase::playerTagRecoveryMult $= "") $Pref::AEBase::playerTagRecoveryMult = 1;
		if ($Pref::AEBase::projectilesAs $= "") $Pref::AEBase::projectilesAs = 3;

		if ($Pref::AEBase::botDamageMult $= "") $Pref::AEBase::botDamageMult = 1;
		if ($Pref::AEBase::botVehicleDamageMult $= "") $Pref::AEBase::botVehicleDamageMult = 0.25;
		if ($Pref::AEBase::botHeadshotMult $= "") $Pref::AEBase::botHeadshotMult = 1;
		if ($Pref::AEBase::botSpreadMult $= "") $Pref::AEBase::botSpreadMult = 1;
		if ($Pref::AEBase::playerSniperHipfireSpreadMult $= "") $Pref::AEBase::playerSniperHipfireSpreadMult = 1;
		if ($Pref::AEBase::botRecoilMult $= "") $Pref::AEBase::botRecoilMult = 1;
		if ($Pref::AEBase::botTagMult $= "") $Pref::AEBase::botTagMult = 1;
		if ($Pref::AEBase::botTagRecoveryMult $= "") $Pref::AEBase::botTagRecoveryMult = 1;
		if ($Pref::AEBase::projectilesAsBot $= "") $Pref::AEBase::projectilesAsBot = 3;

		if ($Pref::AEBase::HUD $= "") $Pref::AEBase::HUD = 0;
		if ($Pref::AEBase::HUDPos $= "") $Pref::AEBase::HUDPos = 0;

		if ($Pref::AEBase::bloodsound $= "") $Pref::AEBase::bloodsound = 1;
		if ($Pref::AEBase::flashlightBlind $= "") $Pref::AEBase::flashlightBlind = 1;
		if ($Pref::AEBase::laserBlind $= "") $Pref::AEBase::laserBlind = 1;
		if ($Pref::AEBase::ads $= "") $Pref::AEBase::ads = 0;
		if ($Pref::AEBase::suppression $= "") $Pref::AEBase::suppression = 1;
		if ($Pref::AEBase::muzzleFlash $= "") $Pref::AEBase::muzzleFlash = 1;
		if ($Pref::AEBase::staticTracers $= "") $Pref::AEBase::staticTracers = 1;

		if ($Pref::AEBase::ammosound $= "") $Pref::AEBase::ammosound = 1;
		if ($Pref::AEBase::ammomessage $= "") $Pref::AEBase::ammomessage = 1;
		if ($Pref::AEBase::ammoitemspin $= "") $Pref::AEBase::ammoitemspin = 1;
		if ($Pref::AEBase::ReserveAmmo $= "") $Pref::AEBase::ReserveAmmo = 1;
		if ($Pref::AEBase::FillReserveOnSpawn $= "") $Pref::AEBase::FillReserveOnSpawn = 1;
		if ($Pref::AEBase::AmmoDeathDrop $= "") $Pref::AEBase::AmmoDeathDrop = 1;
	}
}

AEBase_RegisterPrefs();

$ae_HighIronsFOV = 55;
$ae_LowIronsFOV = 75;
$ae_HighScopeFOV = 8;
$ae_MedScopeFOV = 16;
$ae_LowScopeFOV = 24;

$ae_RifleUPS = 500;
$ae_SniperUPS = 1000;
$ae_AntiMatUPS = 1500;

$ae_falloffPistolStart = 48;
$ae_falloffPistolEnd = 96;
$ae_falloffPistol = 0.75;
$ae_falloffPistolLongStart = 72;
$ae_falloffPistolLongEnd = 96;
$ae_falloffPistolLong = 0.75;
$ae_falloffSMGStart = 96;
$ae_falloffSMGEnd = 160;
$ae_falloffSMG = 0.6;
$ae_falloffRifleStart = 160;
$ae_falloffRifleEnd = 256;
$ae_falloffRifle = 0.6;
$ae_falloffDMRStart = 256;
$ae_falloffDMREnd = 512;
$ae_falloffDMR = 0.7;
$ae_falloffShotgunStart = 32;
$ae_falloffShotgunEnd = 96;
$ae_falloffShotgun = 0.25;
$ae_falloffSniperStart = 96;
$ae_falloffSniperEnd = 256;
$ae_falloffSniper = 2;

if(isFile("Add-Ons/Sound_Blockland/server.cs"))
{
   forceRequiredAddOn("Sound_Blockland");
}
else
{
   datablock AudioProfile(Block_MoveBrick_Sound)
   {
      filename = "base/data/sound/clickMove.wav";
      description = AudioClosest3d;
      preload = false;
   };
   datablock AudioProfile(Block_PlantBrick_Sound)
   {
      filename = "base/data/sound/clickPlant.wav";
      description = AudioClosest3d;
      preload = false;
   };
   datablock AudioProfile(Block_ChangeBrick_Sound)
   {
      filename = "base/data/sound/clickChange.wav";
      description = AudioClosest3d;
      preload = false;
   };
}

function mFloatLerp(%from, %to, %at)
{
    return %to + %at * (%from - %to);
}

function RGBLerp(%from, %to, %at)
{
    %r = mFloatLerp(getWord(%from, 0), getWord(%to, 0), %at);
    %g = mFloatLerp(getWord(%from, 1), getWord(%to, 1), %at);
    %b = mFloatLerp(getWord(%from, 2), getWord(%to, 2), %at);

    return (%r SPC %g SPC %b);
}

function RGBSLerp(%from, %to, %at, %smo)
{
	if(%smo $= "")
		%smo = 1;

	%sm = 1 + mClampF(%smo, -1, 1);
	%r = mClampF(mFloatLerp(getWord(%from, 0), getWord(%to, 0), %at) * %sm, 0, 1);
	%g = mClampF(mFloatLerp(getWord(%from, 1), getWord(%to, 1), %at) * %sm, 0, 1);
	%b = mClampF(mFloatLerp(getWord(%from, 2), getWord(%to, 2), %at) * %sm, 0, 1);

	return (%r SPC %g SPC %b);
}

function rgb2hex( %rgb )
{
    %r = comp2hex( 255 * getWord( %rgb, 0 ) );
    %g = comp2hex( 255 * getWord( %rgb, 1 ) );
    %b = comp2hex( 255 * getWord( %rgb, 2 ) );

    return %r @ %g @ %b;
}

function comp2hex( %comp )
{
    %left = mFloor( %comp / 16 );
    %comp = mFloor( %comp - %left * 16 );

    %left = getSubStr( "0123456789ABCDEF", %left, 1 );
    %comp = getSubStr( "0123456789ABCDEF", %comp, 1 );

    return %left @ %comp;
}

function Player::hideHands(%obj)
{
  if(!%obj.getMountedImage(0).hideHands) return;
  if(%obj.getClassName() $= "AIPlayer")
  {
      %obj.schedule(1, "hidenode", RHand);
      %obj.schedule(1, "hidenode", LHand);
      %obj.schedule(1, "hidenode", Rhook);
      %obj.schedule(1, "hidenode", Lhook);
  }
  else
  {
      %obj.hidenode("RHand");
      %obj.hidenode("LHand");
      %obj.hidenode("Rhook");
      %obj.hidenode("Lhook");
  }
}

function ae_calculateDamagePosition(%pl,%hitPos) // taken from swollow's code but edited not to spam errors on vehicles
{
	if(%pl.IsA("Player") || %pl.IsA("AIPlayer"))
	{
		if(%pl.isCrouched())
		{
			%center = vectorAdd(%pl.getWorldBoxCenter(),"0 0 -1.49");
			%vecTo = vectorNormalize(vectorSub(getWords(%hitPos,0,1) SPC 0,getWords(%center,0,1) SPC 0));
			%forward = %pl.getForwardVector();
			%dot = vectorDot(%vecTo,%forward);
			if(%dot < 0.3)
				return "legs";
			if(%dot < 0.6)
				return "lowbody";
			else
				return "head";
		}
		else
		{
			%z = getWord(%hitPos,2);
			%zWorld = getWord(%pl.getWorldBoxCenter(),2);
			%diff = %zWorld-%z;
			%diff = 2.6-(%diff-2.65);

			if(%diff > 1.8)
				return "head";
			if(%diff > 1.35)
				return "upbody";
			if(%diff > 0.8)
				return "lowbody";
			else
				return "legs";
		}
	}
	else
		return "upbody";
}

function Player::baadDisplayAmmo(%obj, %this)
{
	if(isObject(%obj.client) && %obj.getClassName() $= "Player" && isObject(%this.item.AEType))
	{
		%type = %this.AEUseAmmo;
		%ammo = %obj.AEAmmo[%obj.currTool, %type];
		%automode = %this.item.Auto;
		%ammo_max = %this.item.AEAmmo[%type];
		if(%this.item.AENoReserve[%type])
			%ammo_name = %this.item.AEType[%type];
		else
		{
			%ammo_name = %this.item.AEType[%type].AEAmmo;
			%ammo_reserve = %obj.AEReserve[%this.item.AEType[%type].getID()];
		}

		%ammo_maxres = %this.item.AEType[%type].AEMax;

		if($Pref::AEBase::ReserveAmmo && !%this.item.AENoReserve[%type])
			%ammo_mix = %ammo_reserve;
		else
			%ammo_mix = %ammo_max;

		%at = %ammo / %ammo_max;

		switch($Pref::AEBase::HUD)
		{
			case 0: // aebase
				%start = "1 1 1";
				%end = "1 0 0";
				%final = "<color:" @ rgb2hex(RGBLerp(%start, %end, %at)) @ "><font:impact:54>" @ %ammo @ "<color:FFFFFF><font:arial:54> / <font:impact:54>" @ %ammo_mix @ "<br><font:arial:20>" @ %ammo_name;

			case 1: // tier tac
				%desc = "<font:impact:24><color:fff000>" @ %ammo_name;
				%counter = "<font:impact:34>\c6" @ %ammo @ " / " @ %ammo_mix;
				%final = %desc SPC %counter;

			case 2: // adv pack
				%ammocol = "<color:ffffff>";
				%str = %ammo @ "/" @ %ammo_mix SPC "<font:tahoma:20>AMMO";
				%final = %ammocol @ "<font:impact:24>" @ %str @ " ";

			case 3: // rallypack
				%size = 45 - %ammo_max;
				%size = mClamp(%size, 15, 45);

				if(%ammo_max <= 1)
					%size = 20;

				%string = "<font:impact:15>\c7" @ %ammo_name SPC "<br><font:impact:" @ %size @ ">\c7";

				if(%ammo_max > 1)
				{
					%start = "0 1 0";
					%end = "1 0 0";

					%color = rgb2hex(RGBSLerp(%start, %end, %at));

					for(%i = 0; %i < %ammo_max - %ammo; %i++)
					{
						%string = %string @ "|";
						if((%i + 1) % 50 == 0)
							%string = %string @ " <br> \c7";
					}

					%x = %i;

					%string = %string @ "<color:" @ %color @ ">";

					for(%i = 0; %i < %ammo; %i++)
					{
						if(%ammo > %ammo_max && %i == 0)
						{
							%string = %string @ "+";
						}
						else
						{
							%string = %string @ "|";
							if((%x + %i + 1) % 50 == 0)
								%string = %string @ " <br> <color:" @ %color @ ">";
						}
					}
				}
				else
				{
					if(%ammo >= 0)
					{
						if(%ammo)
							%astring = "\c2Loaded";
						else
							%astring = "\c0Not Loaded";
					}
				}

				%final = %string @ %astring @ " ";

				if($Pref::AEBase::ReserveAmmo)
				{
					%string = "<br><font:impact:15>";

					if(%ammo_reserve > 0)
					{
						%start = "0 1 0";
						%end = "1 0 0";

						%alt = %ammo_reserve / %ammo_maxres;

						%color = rgb2hex(RGBSLerp(%start, %end, %alt));
						%string = %string @ "<color:" @ %color @ ">";
					}
					else
						%string = %string @ "\c7";

					%string = %string @ %ammo_reserve @ " ";

					%final = %final @ %string;
				}

			case 4: // sweps
				%col = "FFFFFF";

				if(%ammo <= 0)
					%col = "ff7777";

				%col = "<color:" @ %col @ ">";

				%final = "<font:impact:34>" @ %col @ %ammo @ " <color:bbbbbb><font:impact:24>" @ %ammo_mix @ " " @ " <color:ffffaa> <br><font:impact:18> " @ %ammo_name;

			case 5: // gcats
				%col = "00FF00";

				if(%ammo <= 0)
					%col = "FF0000";
				else if(%ammo <= %ammo_max / 4)
					%col = "FFFF00";

				%col = "<color:" @ %col @ ">";

				%final = %col @ %ammo @ "/" @ %ammo_mix @ " " @ %ammo_name;

			case 6: // verbal
				%text = "Fully loaded";

				%start = "1 1 1";
				%end = "1 0 0";

				if(%ammo <= 0)
				{
					%text = "Empty";
				}
				else if(%ammo <= %ammo_max / 3)
				{
					%text = "Almost empty";
				}
				else if(%ammo <= %ammo_max / 2)
				{
					%text = "Half full";
				}
				else if(%ammo <= %ammo_max - 1)
				{
					%text = "Loaded";
				}


				%final = "<font:Impact:35><color:" @ rgb2hex(RGBLerp(%start, %end, %at)) @ ">" @ %text;

				if($Pref::AEBase::ReserveAmmo)
				{
					%text = "Reserve full";

					if(%ammo_reserve <= 0)
					{
						%text = "Reserve empty";
					}
					else if(%ammo_reserve <= %ammo_maxres / 3)
					{
						%text = "Reserve almost empty";
					}
					else if(%ammo_reserve <= %ammo_maxres / 2)
					{
						%text = "Reserve half full";
					}
					else if(%ammo_reserve <= %ammo_maxres - 1)
					{
						%text = "Reserve almost full";
					}

					%final = %final @ "<br><font:impact:20><color:" @ rgb2hex(RGBLerp(%start, %end, %ammo_reserve / %ammo_maxres)) @ ">" @ %text;
				}

			case 7: // bkt
				%desc = "<font:impact:24><color:FF0000>" @ %ammo_name;
				%counter = "<font:impact:34>\c6" @ %ammo @ " / " @ %ammo_mix;
				%final = %desc SPC %counter;

			case 8: // blockality
			    if(%automode == 1)
				%firemode = "|||";
                else
				%firemode = "|";
				%desc = "<font:impact:24><color:FF0000>" @ %firemode @"  <font:impact:34>\c6";
				%counter = %ammo @ " / " @ %ammo_mix;
				%final = %desc SPC %counter;

			case 9: // nekram
				%desc = "<color:0aa000><font:Arial:20>\c6";
				%counter = %ammo @ " / " @ %ammo_mix;
				%final = %desc SPC %counter;

			case 10: // tactical
				%desc = "<color:0aa000><font:impact:38>\c6";
				%counter = %ammo @ " / " @ %ammo_mix;
				%final = %desc SPC %counter;

			case 11: // none
				// do nothing lol
				return;
		}

		%pos = $Pref::AEBase::HUDPos;

		if(%pos <= 2)
		{
			if(%pos == 0)
				%final = "<just:right>" @ %final;
			else if(%pos == 1)
				%final = "<just:left>" @ %final;
			else if(%pos == 2)
				%final = "<just:center>" @ %final;

			%obj.client.bottomPrint(%final, -1, 1);
		}
		else
		{
			if(%pos == 3)
				%final = "<br><br><br><br><br><br><br><just:center>" @ %final;
			else if(%pos == 4)
				%final = "<just:right>" @ %final;
			else if(%pos == 5)
				%final = "<just:left>" @ %final;

			%obj.client.centerPrint(%final, -1);
		}
	}
}

package NoDeathHud
{
  function GameConnection::onDeath(%cl, %sPl, %sCl, %dmType, %pos)
  {
      if($Pref::AEBase::HUDPos < 3 || $Pref::AEBase::HUD != 11)
        %cl.bottomPrint("", 1, 1);

      return Parent::onDeath(%cl, %sPl, %sCl, %dmType, %pos);
  }
};
activatePackage(NoDeathHud);

package HandCorrection
{
  function GameConnection::ApplyBodyParts(%cl)
  {
    Parent::ApplyBodyParts(%cl);
    if(isObject(%pl = %cl.Player))
    {
      if(%pl.getMountedImage(0).hideHands)
        %pl.schedule(0, hideHands);
    }
  }
};
activatePackage(HandCorrection);

package AudioRandomPitch
{
	function GameConnection::Play3D(%cl, %sound, %pos)
	{
		%pitchDev = %sound.pitchRange;
		if(%pitchDev $= "" || $noPitchShift) return Parent::Play3D(%cl, %sound, %pos);

		%maxPitch = 100 + %pitchDev;
		%minPitch = 100 - %pitchDev;

		%pitch = (getRandom(%minPitch, %maxPitch)) / 100;

		$oldTimescale = getTimescale();
		setTimescale(%pitch);

		Parent::Play3D(%cl, %sound, %pos);

		setTimescale($oldTimescale);
	}

	function GameConnection::Play2D(%cl, %sound)
	{
		%pitchDev = %sound.pitchRange;
		if(%pitchDev $= "" || $noPitchShift) return Parent::Play2D(%cl, %sound);

		%maxPitch = 100 + %pitchDev;
		%minPitch = 100 - %pitchDev;

		%pitch = (getRandom(%minPitch, %maxPitch)) / 100;

		$oldTimescale = getTimescale();
		setTimescale(%pitch);

		Parent::Play2D(%cl, %sound);

		setTimescale($oldTimescale);
	}

	function serverPlay3D(%sound, %pos)
	{
		%pitchDev = %sound.pitchRange;
		if(%pitchDev $= "") return Parent::serverPlay3D(%sound, %pos);
		%maxPitch = 100 + %pitchDev;
		%minPitch = 100 - %pitchDev;

		%pitch = (getRandom(%minPitch, %maxPitch)) / 100;

		$oldTimescale = getTimescale();
		setTimescale(%pitch);

		$noPitchShift = true;
		%p = Parent::serverPlay3D(%sound, %pos);
		$noPitchShift = false;

		setTimescale($oldTimescale);

		return %p;
	}

	function serverPlay2D(%sound)
	{
		%pitchDev = %sound.pitchRange;
		if(%pitchDev $= "") return Parent::serverPlay2D(%sound);

		%maxPitch = 100 + %pitchDev;
		%minPitch = 100 - %pitchDev;

		%pitch = (getRandom(%minPitch, %maxPitch)) / 100;

		$oldTimescale = getTimescale();
		setTimescale(%pitch);

		$noPitchShift = true;
		%p = Parent::serverPlay2D(%sound);
		$noPitchShift = false;

		setTimescale($oldTimescale);
		return %p;
	}
};

if($Server::Dedicated) // this feature sometimes causes issues on non dedi servers
	activatePackage(AudioRandomPitch);

if(isFile($f = "config/server/aefov.cs"))
	exec($f);

function serverCmdFov(%cl, %fov)
{
	%fov = mClampF(%fov, 0, 160);

	if(%fov >= 1)
	{
		%cl.aeReferenceFOV = %fov;
		messageClient(%cl, '', "\c5Set reference FOV to \c1" @ %fov @ "\c5.");
		$AEReferenceFov_[%cl.getBLID()] = %fov;
	}
	else
	{
		%cl.aeReferenceFOV = "";
		messageClient(%cl, '', "\c5Removed reference FOV.");
		deleteVariables("$AEReferenceFov_" @ %cl.getBLID());
	}

	export("$AEReferenceFOV_*", "config/server/aefov.cs");
}

function GameConnection::aeFovCheck(%cl, %img)
{
	if((%fov = $AEReferenceFOV_[%cl.getBLID()]) !$= "")
		%cl.aeReferenceFOV = %fov;

	//%fov = mClampF(%img.desiredFOV, 0, 160);
	if(%cl.aeReferenceFOV > 0)
	{
		%cl.aeFovTransition(%img);
	}
	else if(!%cl.aeFovNotified)
	{
		messageClient(%cl, '', "\c5You don't have a reference FOV set. You will still be able to ADS but your FOV will not be changed.");
		messageClient(%cl, '', "\c5Use \c1/fov \c5to set a reference FOV.");
		%cl.aeFovNotified = true;
	}
}

function GameConnection::aeFovTransition(%cl, %img)
{
	cancel(%cl.aeFov);

	if(!isObject(%cl) || !isObject(%pl = %cl.Player) || (isObject(%img) && %pl.getMountedImage(0).getID() != %img.getID()))
		return;

	%target = %img.desiredFOV;

	if(!isObject(%img) || %img.desiredFOV < 1)
		%target = %cl.aeReferenceFOV;

	%fov = mFloatLerp(%cl.getControlCameraFOV(), %target, 0.55);

	if(mAbs(%fov - %target) < 0.4 || !%cl.zoomLerp)
		%fov = %target;

	%cl.setControlCameraFOV(%fov);

	if(%fov == %target)
		return;

	%cl.aeFov = %cl.schedule(32, aeFovTransition, %img);
}

function Player::aeUpdateSpeed(%player, %speedMaul) // gently borrowed from rallypack
{
	%data = %player.getDatablock();

	%forwardSpeed = %data.maxForwardSpeed;
	%backwardSpeed = %data.maxBackwardSpeed;
	%strafeSpeed = %data.maxSideSpeed;
	%forwardSpeedCrouching = %data.maxForwardCrouchSpeed;
	%backwardSpeedCrouching = %data.maxBackwardCrouchSpeed;
	%strafeSpeedCrouching = %data.maxSideCrouchSpeed;

	if(%speedMaul $= "")
		%speedMaul = 1;

	for(%i = 0; %i < 4; %i++)
	{
		%image = %player.getMountedImage(%i);
		if(%image.R_MovePenalty !$= "")
		{
			%speedMaul *= %image.R_MovePenalty;
		}
		else if(%image.R_InheritImage.R_MovePenalty !$= "")
		{
			%speedMaul *= %image.R_InheritImage.R_MovePenalty;
		}
	}

	if(%player.r_hittag !$= "")
		%speedMaul *= %player.r_hittag;

	if(%player.rex_stun !$= "")
		%speedMaul *= %player.rex_stun;

	%forwardSpeed *= %speedMaul;
	%backwardSpeed *= %speedMaul;
	%strafeSpeed *= %speedMaul;
	%forwardSpeedCrouching *= %speedMaul;
	%backwardSpeedCrouching *= %speedMaul;
	%strafeSpeedCrouching *= %speedMaul;

	%player.setMaxForwardSpeed(%forwardSpeed);
	%player.setMaxBackwardSpeed(%backwardSpeed);
	%player.setMaxSideSpeed(%strafeSpeed);
	%player.setMaxCrouchForwardSpeed(%forwardSpeedCrouching);
	%player.setMaxCrouchBackwardSpeed(%backwardSpeedCrouching);
	%player.setMaxCrouchSideSpeed(%strafeSpeedCrouching);
}

function Player::aeTagHit(%player, %strength, %recovery)
{
	if(%player.r_hittag $= "")
		%player.r_hittag = 1;

	%player.r_hittag = mFloatLerp(%player.r_hittag, 0.02, 1-%strength);
	%player.aeUpdateSpeed();
	cancel(%player.r_tagdecayquota);
	%player.r_tagdecayquota = %player.schedule(33, aeTagDecayLoop, %recovery);
}

function Player::aeTagDecayLoop(%player, %recovery)
{
	%player.r_hittag *= 1 + %recovery;

	if(%player.r_hittag < 0.99)
	{
		cancel(%player.r_tagdecayquota);
		%player.r_tagdecayquota = %player.schedule(33, aeTagDecayLoop, %recovery);
	}
	else
	{
		%player.r_hittag = 1;
	}

	%player.aeUpdateSpeed();
}

registerOutputEvent(Player, "setAEDamageMult", "float 0 10 0.05 1");
registerOutputEvent(Bot, "setAEDamageMult", "float 0 10 0.05 1");
registerOutputEvent(Player, "resetAEDamageMult");
registerOutputEvent(Bot, "resetAEDamageMult");

registerOutputEvent(Bot, "setAEInfiniteAmmo", "bool");
registerOutputEvent(Bot, "setAEScoped", "bool");

function Player::setAEDamageMult(%pl, %mult)
{
	%pl.AEDamageMult = %mult;
}

function Player::resetAEDamageMult(%pl)
{
	%pl.AEDamageMult = "";
}

function AIPlayer::setAEScoped(%pl, %val)
{
	%src = %pl.getMountedImage(0);

	if(isObject(%src.sourceImage))
		%img = %src.sourceImage;
	else
		%img = %src;

	%itm = %img.item;

	if(!isObject(%img))
		return;

	if(%val)
		%next = %img.scopingImage;
	else
		%next = %img;

	if(%src.getID() == %next.getID())
		return;

	if(isObject(%next))
		%pl.mountImage(%next, 0);
}

function AIPlayer::setAEInfiniteAmmo(%pl, %val)
{
	%pl.AEInfAmmo = %val;
}

function AEBase_ADSTick()
{
	cancel($AEBase::ADSTick);

	%cg = nameToID("ClientGroup");
	if(%cg < 0)
		return;

	$AEBase::ADSTick = schedule(100, 0, AEBase_ADSTick);

	%co = %cg.getCount();
	for(%i = 0; %i < %co; %i++)
	{
		%cl = %cg.getObject(%i);
		if(%cl.adsHold && isObject(%pl = %cl.player))
		{
			%img = %pl.getMountedImage(0);
			%isADS = isObject(%img.sourceImage);
			if(isObject(%img.scopingImage) && (%isADS ^ %pl.adsTrigger))
			{
				%state = %pl.getImageState(0);
				if(%state $= "Ready" || %state $= "Smoke" || %state $= "Empty" || %state $= "Cock" || %state $= "Cocked" || %state $= "EmptyAlt" || %state $= "EmptyA")
					%pl.mountImage(%img.scopingImage, 0);
			}
		}
	}
}
AEBase_ADSTick();

function Player::BipodVelocityCheck(%pl)
{
	cancel(%pl.bvc);

	if(!isObject(%img = %pl.getMountedImage(0)) || !%img.isBipod)
		return;
	
	if(vectorLen(%pl.getVelocity()) > 0.1)
		return %pl.mountImage(%img.safetyImage, 0);

	%pl.bvc = %pl.schedule(75, BipodVelocityCheck);
}

package WeaponFeatures
{
	function Armor::doDismount(%this, %obj, %forced) {
		if(%obj.isMounted() && isObject(%img = %obj.getMountedImage(0)) && %img.item.aebase && !%forced)
		{
			if($Pref::AEBase::ads == 0 || %img.scopingImage.isScopedImage || %img.scopingImage $= %img.sourceImage)
				return;
		}
		
		return Parent::doDismount(%this, %obj, %forced);
	}

	function serverCmdPlantBrick(%client)
	{
		%obj = %client.player;
		if(isObject(%obj) && isObject(%img = %obj.getMountedImage(0).safetyImage) && (%obj.getMountedImage(0).isSafetyImage ||
		%obj.getImageState(0) $= "Ready" || %obj.getImageState(0) $= "Smoke" || %obj.getImageState(0) $= "Cock" || %obj.getImageState(0) $= "Cocked" || %state $= "EmptyAlt" || %state $= "EmptyA"))
		{
			if(!%img.isBipod || vectorLen(%obj.getVelocity()) <= 0.1)
			{
				%obj.showText = 1;
				%obj.schedule(0, BipodVelocityCheck);
				%obj.mountImage(%img, 0);
			}
		}
		parent::serverCmdPlantBrick(%client);
	}

	function Armor::onTrigger(%this, %player, %slot, %val)
	{
		Parent::onTrigger(%this, %player, %slot, %val);

		if($Pref::AEBase::ads == 2 || %player.IsA("AIPlayer"))
			return;

		%img = %player.getMountedImage(0);
		if(%slot == 2 && %val && %img.isBipod)
		{
			%player.mountImage(%img.safetyImage, 0);
			return;
		}

		if(%slot != 4)
			return;
		
		%player.adsTrigger = %val;

		%img = %player.getMountedImage(0).scopingImage;
		if (!isObject(%img))
			return;

		%state = %player.getImageState(0);

		%cl = %player.client;
		if(%cl.adsHold)
			%doADS = (!%val && isObject(%img.scopingImage.sourceImage)) || (%val && !%img.isScopedImage);
		else
			%doADS = %val;

		if(%doADS && isObject(%img) && (%state $= "Ready" || %state $= "Smoke" || %state $= "Empty" || %state $= "Cock" || %state $= "Cocked" || %state $= "EmptyAlt" || %state $= "EmptyA"))
		{
			if($Pref::AEBase::ads == 0 || ($Pref::AEBase::ads == 1 && %img.isScopedImage && isObject(%img.sourceImage)) || (!isObject(%img.sourceImage) || %img.sourceImage.getID() == %img.getID()))
				%player.mountImage(%img, 0);
		}

		//if(%val)
		//{
		//	if (isObject(%img = %player.getMountedImage(0).scopingImage) && %slot == 4 && (%player.getImageState(0) $= "Ready" || %player.getImageState(0) $= "Smoke" || %player.getImageState(0) $= "Empty"))
		//	{
		//		if($Pref::AEBase::ads == 0 || ($Pref::AEBase::ads == 1 && %img.isScopedImage && isObject(%img.sourceImage)) || (!isObject(%img.sourceImage) || %img.sourceImage.getID() == %img.getID()))
		//			%player.mountImage(%img, 0);
		//	}
		//}
	}

	function serverCmdUseTool(%cl, %slot)
	{
		if(isObject(%pl = %cl.Player) && %pl.blockImageDismount)
		{
			%pl.tempItemSlot = %slot;
			return;
		}

		Parent::serverCmdUseTool(%cl, %slot);
	}

	function serverCmdUnuseTool(%cl)
	{
		if(isObject(%pl = %cl.Player) && %pl.blockImageDismount)
		{
			%pl.tempItemSlot = -1;
			return;
		}

		Parent::serverCmdUnuseTool(%cl);
	}

	function Armor::onAdd(%db, %pl)
	{
		Parent::onAdd(%db, %pl);

		if(isObject(%cl = %pl.Client) && %cl.aeReferenceFOV > 0)
			%cl.schedule(0, setControlCameraFOV, %cl.aeReferenceFOV);
	}

	function Projectile::onAdd(%obj,%a,%b)
	{
		if(%obj.velocityIncrease > 0)
			%obj.initialvelocity = vectorscale(vectorNormalize(%obj.initialvelocity),%obj.velocityIncrease);

		Parent::onAdd(%obj,%a,%b);
	}
};
ActivatePackage(WeaponFeatures);

function Player::unBlockImageDismount(%pl)
{
	if(!isObject(%cl = %pl.Client) || %cl.IsA("AIPlayer"))
		return;

	if(!%pl.blockImageDismount)
		return;

	%pl.blockImageDismount = false;

	if(%pl.tempItemSlot $= "")
		return;

	if(%pl.tempItemSlot == -1)
		schedule(0, %cl, serverCmdUnuseTool, %cl);
	else if(%pl.currTool != %pl.tempItemSlot)
		schedule(0, %cl, serverCmdUseTool, %cl, %pl.tempItemSlot);

	%pl.tempItemSlot = "";
}

function Item::collisionLoop(%this, %before) // epicly borrowed from jack noir's complex pack (and edited
{
	cancel(%this.collisionLoop);

	if(%this.static)
		return;
	
	%data = %this.getDatablock();
	%now = vectorLen(%this.getVelocity());

	if (%before - %now >= %data.softImpactThreshold)
	{
		if(%before - %now >= %data.hardImpactThreshold)
			serverPlay3D(getWord((%his = %data.hardImpactSound), getRandom(0, getWordCount(%his))), %this.getPosition());
		else
			serverPlay3D(getWord((%sis = %data.softImpactSound), getRandom(0, getWordCount(%sis))), %this.getPosition());
	}

	%this.collisionLoop = %this.schedule((%now > 0.1 ? 50 : 200), "collisionLoop", %now);
}

package WeaponDroping
{
	function servercmdDropTool(%client,%slot)
	{
    %player = %client.player;
    if(isObject(%player) && isObject(%image = %player.getMountedImage(0)) && %image.item.aebase)
    {
      %player.unmountImage(0);
    }
    return Parent::servercmdDropTool(%client,%slot);
	}

	function ItemData::OnAdd(%db, %item)
	{
		if(%db.useImpactSounds && isObject(%item))
			%item.collisionLoop();

		Parent::onAdd(%db, %item);
	}
};
ActivatePackage(WeaponDroping);

function Player::AEFire(%obj,%this,%slot)
{
	if(%obj.getDamagePercent() >= 1)
	return;

	%src = %obj.getMuzzlePoint(%slot);
	%sfx = %this.farShotSound;
	%dist = %this.farShotDistance;

	for(%i = 0; %i < ClientGroup.getCount(); %i++)
	{
		%cc = ClientGroup.getObject(%i);
		%targ = %cc.getControlObject();
		if(!isObject(%targ))
			continue;

		if(vectorDist(%targ.getTransform(), %src) > %dist)
			%cc.play3D(%sfx, %src);
	}

	if(getSimTime()-%obj.lastShellSound > 800 || getRandom(0,1) == 0)
	{
		%obj.lastShellSound = getSimTime();
		schedule(getRandom(%this.ShellSoundMin,%this.ShellSoundMax),0,serverPlay3D,%this.shellSound @ getRandom(1,3) @ Sound,%obj.getPosition());

		if(vectorLen(%this.muzzleFlashScale) > 0 && $Pref::AEBase::muzzleFlash)
		{
			%p = new (%this.projectileType)()
			{
				dataBlock = AEFlashProjectile;
				initialVelocity = %velocity;
				initialPosition = %obj.getMuzzlePoint(%slot);
				sourceObject = %obj;
				sourceSlot = %slot;
				client = %obj.client;
				scale = %this.muzzleFlashScale;
			};
			MissionCleanup.add(%p);
		}
	}

	if(getSimTime() - %obj.lastShotTime[%this] < %this.spreadReset)
	{
		%obj.burst[%this]++;
	}
	else
	{
		%obj.burst[%this] = 1;
		%obj.boundDir[%this] = getRandom(0, 1);
		if(!%obj.boundDir[%this])
			%obj.boundDir[%this] = -1;

		%obj.dirFlip[%this] = getRandom(12, 20);

		%obj.climb[%this] = 0;
		%obj.spray[%this] = 0;
	}

	%recx = %this.recoilWidth / 100;
	%recz = %this.recoilHeight / 100;
	%recxm = %this.recoilWidthMax / 100;
	%reczm = %this.recoilHeightMax / 100;

	%grace = %this.spreadBurst;

	%spreadMin = %this.spreadMin;
	%spreadMax = %this.spreadMax;

	if (%obj.getClassName() $= "Player")
		%spreadMult = (%this.gunType $= "Sniper" && !isObject(%this.sourceImage)) ? $Pref::AEBase::playerSniperHipfireSpreadMult : $Pref::AEBase::playerSpreadMult;
	else
		%spreadMult = (%this.gunType $= "Sniper" && !isObject(%this.sourceImage)) ? $Pref::AEBase::botSniperHipfireSpreadMult : $Pref::AEBase::botSpreadMult;

	%d = 10000;

	%tag = %this.projectileTagStrength;
	%tagRec = %this.projectileTagRecovery;

	if(%obj.getClassName() $= "Player")
	{
		%recx *= $Pref::AEBase::playerRecoilMult;
		%recz *= $Pref::AEBase::playerRecoilMult;
		%recxm *= $Pref::AEBase::playerRecoilMult;
		%reczm *= $Pref::AEBase::playerRecoilMult;


		%spreadMin *= %spreadMult;
		%spreadMax *= %spreadMult;

		if(!%this.projectileTagIgnore)
		{
			%tagRec *= $Pref::AEBase::playerTagRecoveryMult;
			%tag *= $Pref::AEBase::playerTagMult;
		}
	}
	else
	{
		%recx *= $Pref::AEBase::botRecoilMult;
		%recz *= $Pref::AEBase::botRecoilMult;
		%recxm *= $Pref::AEBase::botRecoilMult;
		%reczm *= $Pref::AEBase::botRecoilMult;

		%spreadMin *= %spreadMult;
		%spreadMax *= %spreadMult;

		if(!%this.projectileTagIgnore)
		{
			%tagRec *= $Pref::AEBase::botTagRecoveryMult;
			%tag *= $Pref::AEBase::botTagMult;
		}
	}

	for(%i = 0; %i < %this.projectileCount; %i++)
	{
		%vector = %obj.getMuzzleVector(0);
		if(%obj.burst[%this] <= %grace)
		{
			if(%obj.burst[%this] == 1)
			{
				%spreadMin = %this.spreadBase;

				if(%obj.getClassName() $= "Player")
					%spreadMin *= %spreadMult;
				else
					%spreadMax *= %spreadMult;
			}
			%vector = vectorAdd(%vector, (%spreadMin / %d) * (getRandom() - 0.5) SPC (%spreadMin / %d) * (getRandom() - 0.5) SPC (%spreadMin / %d) * (getRandom() - 0.5));
		}
		else
		{
			%spread = mFloatLerp(%spreadMax, %spreadMin, %obj.spray[%this]);

			%spreadx = (%spread / %d) * (getRandom() - 0.5);
			%spready = (%spread / %d) * (getRandom() - 0.5);
			%spreadz = (%spread / %d) * (getRandom() - 0.5);

			if(%recz > 0)
			{
				%climb = (%obj.burst[%this] - %grace) * %recz;
				%climb = mClampF(%climb, 0.0, %reczm);
				%progress = 0 + %climb / %reczm * (1 - 0);
				%climb += (%spreadz / 2);
			}
			else
				%climb = 0;

			%obj.climb[%this] = %climb;
			%obj.spray[%this] = %progress;

			%bound = (%obj.burst[%this] - %grace) * %recx;
			%bound = %bound * %obj.boundDir[%this];

			// I honestly don't even know how the fuck this works anymore
			if(%obj.dirFlip[%this] <= %obj.burst[%this])
			{
				%bound = (%bound + (-%obj.boundDir[%this] * (%obj.burst[%this] - %obj.dirFlip[%this]) / (100 * 0.35)));
			}

			%bound = mClampF(%bound, -%recxm, %recxm);

			%vector = vectorAdd(%vector, %spreadx + %bound SPC %spready + %bound SPC %spreadz + %climb);
			%vector = vectorNormalize(%vector);
		}

		%projType = (%obj.IsA("Player") ? $Pref::AEBase::projectilesAs : $Pref::AEBase::projectilesAsBot);

		if(%this.alwaysSpawnProjectile || %projType != 1 && !%this.staticHitscan || %projType == 0 || %projType == 4)
		{
			%velocity = vectorScale(%vector, %this.projectileVelocity);

			%directDamage = %this.projectileDamage;
			%headshotMult = %this.projectileHeadshotMult;
			%vehicleMult = %this.projectileVehicleDamageMult;

			if(%obj.getClassName() $= "Player")
			{
				if(%obj.AEDamageMult !$= "")
					%directDamage *= %obj.AEDamageMult;
				else
					%directDamage *= $Pref::AEBase::playerDamageMult;
				%headshotMult *= $Pref::AEBase::playerHeadshotMult;
				if(%vehicleMult $= "")
					%vehicleMult = $Pref::AEBase::playerVehicleDamageMult;
			}
			else
			{
				if(%obj.AEDamageMult !$= "")
					%directDamage *= %obj.AEDamageMult;
				else
					%directDamage *= $Pref::AEBase::playerDamageMult;
				%headshotMult *= $Pref::AEBase::botHeadshotMult;
				if(%vehicleMult $= "")
					%vehicleMult = $Pref::AEBase::botVehicleDamageMult;
			}

			if(%headshotMult <= 0)
				%headshotMult = 1;

			%velInc = 0;
			
			%pdata = %this.projectile;

			if(%projType == 4 && %this.staticUnitsPerSecond > 0 && (%pdata.getID() == AEProjectile.getID() || %pdata.getID() == AETrailedProjectile.getID()))
			{
				%velInc = %this.staticUnitsPerSecond;
				%pdata = AETraillessProjectile;
			}

			%projectile = new Projectile ()
			{
				dataBlock = %pdata;
				initialVelocity = vectorAdd(%velocity, "0 0 " @ %this.projectileZOffset);
				initialPosition = %obj.getMuzzlePoint(%slot);
				sourcePosition = %obj.getMuzzlePoint(%slot);
				sourceObject = %obj;
				sourceSlot = %slot;
				sourceImage = %this;
				client = %obj.client;
				scale = %this.bulletScale;
				directDamage = %directDamage;
				vehicleDamage = %vehicleMult;
				headshotMult = %headshotMult;
				sonicWhizz = %this.sonicWhizz;
				whizzSupersonic = %this.whizzSupersonic;
				whizzThrough = %this.whizzThrough;
				whizzDistance = %this.whizzDistance;
				whizzChance = %this.whizzChance;
				whizzAngle = %this.whizzAngle;
				velocityIncrease = %velInc;
				tagStrength = %tag;
				tagRecover = %tagRec;
				RGibExplosionBody = %this.projectileRGibExplosionBody;
				RGibExplosionHead = %this.projectileRGibExplosionHead;
				falloffStart = %this.projectileFalloffStart;
				falloffEnd = %this.projectileFalloffEnd;
				falloffDamage = %this.projectileFalloffDamage;
				directDamageType = %this.directDamageType;
				directHeadDamageType = %this.directHeadDamageType;
				RDismemberBody = %this.projectileRDismemberBody;
				RDismemberHead = %this.projectileRDismemberHead;
			};
			MissionCleanup.add(%projectile);
		}
		else if(%projType == 3 && %this.staticHitscan)
		{
			%vec = vectorNormalize(vectorAdd(vectorScale(%vector, %this.projectileVelocity), "0 0 " @ %this.projectileZOffset));
			createStaticHitscan_aebase(%obj, %this, %obj.getMuzzlePoint(%slot), %vec);
		}
		else if(%projType == 2 && %this.staticHitscan || %projType == 1 || %this.staticRealHitscan)
		{
			%vec = vectorNormalize(vectorAdd(vectorScale(%vector, %this.projectileVelocity), "0 0 " @ %this.projectileZOffset));
			%obj.fireRaycastProjectile(%this, %obj.getMuzzlePoint(%slot), %vec);
		}
	}

	%obj.lastShotTime[%this] = getSimTime();

	%lclimb = %this.medClimbThreshold;
	if(%lclimb $= "") %lclimb = 0.05;

	%hclimb = %this.highClimbThreshold;
	if(%hclimb $= "") %hclimb = 0.1;

	if(%climb > %hclimb)
	{
		%this.AEOnHighClimb(%obj, %slot);
	}
	else if(%climb > %lclimb)
	{
		%this.AEOnMedClimb(%obj, %slot);
	}
	else
	{
		%this.AEOnLowClimb(%obj, %slot);
	}

	if($Pref::AEBase::playerScreenshakeMult > 0.1)
	{
		if (%reczm == 0)
			%reczm = %this.recoilHeightMax / 100;

		%size = %this.screenshakeMin + %climb / %reczm * (%this.screenshakeMax - %this.screenshakeMin);
		%size *= $Pref::AEBase::playerScreenshakeMult;
		%recoil = vectorScale("1 1 1", %size);
		if(%obj.getClassName() $= "Player")
		{
			%p = new (%this.projectileType)()
			{
				dataBlock = R_ShotgunRecoilProjectile;
				initialPosition = %obj.getPosition();
				scale = %recoil;
			};
			MissionCleanup.add(%p);
		}
	}
	
    if(%this.concBlastProj !$= "")
	{
			%p = new (%this.projectileType)()
			{
			dataBlock = ShotgunBlastProjectile;
            directDamage = %this.concBlastDamage;
            vehicleDamage = %vehicleMult;
			initialVelocity = vectorScale(%obj.getMuzzleVector(0), 100);
			initialPosition = %obj.getMuzzlePoint(%slot);
			sourceObject = %obj;
			sourceSlot = %slot;
			client = %obj.client;
			scale = %this.concBlastScale;
		};
			MissionCleanup.add(%p);
	}
	
}

function WeaponImage::AEOnHighClimb(%this, %obj, %slot)
{
	%obj.playThread(2, jump);
}

function WeaponImage::AEOnMedClimb(%this, %obj, %slot)
{
	%obj.playThread(2, plant);
}

function WeaponImage::AEOnLowClimb(%this, %obj, %slot)
{

}

function WeaponImage::AELoadCheck(%this, %obj, %slot)
{
	%this.AEPreLoadAmmoReserveCheck(%obj, %slot);
	if(!%obj.getImageLoaded(%slot))
	{
		%obj.setImageAmmo(%slot, 1);
		return;
	}
	%this.AEPreAmmoCheck(%obj, %slot);
}

function WeaponImage::AEOnFire(%this, %obj, %slot)
{
	%obj.AEFire(%this, %slot);
	%obj.AEAmmo[%obj.currTool, %this.AEUseAmmo]--;
	%obj.baadDisplayAmmo(%this);
	%this.AEPreAmmoCheck(%obj, %slot);
}

function WeaponImage::AEOnEmpty(%this, %obj, %slot)
{
	if(getSimTime() - %obj.reloadTime[%this.getID()] <= %this.stateTimeoutValue[0] * 1000 + 1000)
		%obj.schedule(0, setImageAmmo, %slot, 1);
	%obj.baadDisplayAmmo(%this);
}

function WeaponImage::AEOnEmptyA(%this, %obj, %slot)
{
    %obj.setImageAmmo(%slot, 1);
}

function WeaponImage::AEShotgunLoadCheck(%this, %obj, %slot)
{
	%this.AEPreMagAmmoCheck(%obj, %slot);
	%this.AEPreLoadAmmoReserveCheck(%obj, %slot);
}

function WeaponImage::AEShotgunAltLoadCheck(%this, %obj, %slot)
{
	%this.AEPreMagAmmoCheck(%obj, %slot);
	%this.AEPreLoadReserveCheck(%obj, %slot);
}

function WeaponImage::AEMagLoadCheck(%this, %obj, %slot)
{
	%this.AEPreAmmoCheck(%obj, %slot);
	%this.AEPreLoadAmmoReserveCheck(%obj, %slot);
}

function WeaponImage::AEUnmountCleanup(%this, %obj, %slot)
{
	if(%obj.getClassName() $= "AIPlayer")
	{
		GameConnection::applyBodyParts(%obj);
	}
	else
	{
		%obj.client.applyBodyParts();
		if($Pref::AEBase::HUD != 11)
		if($Pref::AEBase::HUDPos <= 2) 
			%obj.client.bottomPrint("", 1, 1);
		else
			%obj.client.centerPrint("", 1);
	}
			

	if(%obj.FireLoop)
        %obj.playAudio(0, %this.loopingEndSound);

	cancel(%obj.aeLaser);

	%obj.schedule(0, aeUpdateSpeed);

	if(isObject(%cl = %obj.client))
			%cl.aeFovCheck();
}

function WeaponImage::AEMountSetup(%this, %obj, %slot)
{
	%idx = %obj.currTool;
	%itm = %obj.tool[%idx];
	%type = %this.AEUseAmmo;

	if(%obj.IsA("AIPlayer"))
	{
		%itm = %obj.getMountedImage(0).item;
		%idx = "";

		if(!isObject(%obj.aeLastItem) || %obj.aeLastItem != %itm)
		{
			%obj.AEAmmo["", %type] = %itm.AEAmmo["", %type];
		}
	}

	if(%obj.aeAmmo[%idx, %type] > %itm.aeAmmo[%type])
		%obj.aeAmmo[%idx, %type] = %itm.aeAmmo[%type];
	else if(%obj.aeAmmo[%idx, %type] < 0)
		%obj.aeAmmo[%idx, %type] = 0;
	else if(%obj.aeAmmo[%idx, %type] $= "")
		%obj.aeAmmo[%idx, %type] = %itm.aeAmmo[%type];

	%obj.aeLastItem[%idx] = %itm;

	%obj.hideHands(%this);
	%obj.baadDisplayAmmo(%this);
	%obj.aeLaserLoop(%this);

	%obj.aeUpdateSpeed();

  %obj.FireLoop = false;

	if(isObject(%cl = %obj.client))
	{
		%cl.aeFovCheck(%this);
		if(!%cl.aeHelpNotified)
		{
			messageClient(%cl, '', "\c5Hey, you can use /aeHelp to see all the commands you can use.");

			if((%val = $AEClient_ADSHold[%cl.getBLID()]) !$= "")
				%cl.adsHold = %val;
				
			if((%val = $AEClient_NoZoom[%cl.getBLID()]) !$= "")
				%cl.zoomLerp = %val;
				
			%cl.aeHelpNotified = true;
		}
	}
}

function WeaponImage::AEShotgunLoadOne(%this, %obj, %slot)
{
	%obj.AEShellReload();
	%obj.baadDisplayAmmo(%this);
	%this.AEPreMagCheck(%obj, %slot);
	%this.AEPreLoadAmmoReserveCheck(%obj, %slot);
}

function WeaponImage::AEMagReloadAll(%this, %obj, %slot)
{
	%obj.AEMagReload();
	%obj.baadDisplayAmmo(%this);
	%this.AEPreAmmoCheck(%obj, %slot);
	%this.AEPreLoadAmmoReserveCheck(%obj, %slot);
}

// should probably move all this laser related stuff elsewhere

if(isFile($f = "config/server/aebasecl.cs"))
 	exec($f);

// function serverCmdLaserColor(%cl, %r, %g, %b) // ae got salty because this would result in inconsistent color (red gun laser + green laser dot)
// {
// 	%r = trim(%r);
// 	%g = trim(%g);
// 	%b = trim(%b);

// 	if(%r $= "" || %g $= "" || %b $= "")
// 	{
// 		messageClient(%cl, '', "\c5Invalid color");
// 		messageClient(%cl, '', "\c5Usage: /LaserColor [r] [g] [b]");
// 		return;
// 	}

// 	if(%r > 1 || %g > 1 || %b > 1)
// 	{
// 		%r *= 1/255;
// 		%g *= 1/255;
// 		%b *= 1/255;
// 	}

// 	%r = mClampF(%r, 0, 1);
// 	%g = mClampF(%g, 0, 1);
// 	%b = mClampF(%b, 0, 1);

// 	%col = %r SPC %g SPC %b;

// 	%cl.aeLaserColor = %col SPC "1";

// 	if(isObject(%dot = %cl.Player.laserDot))
// 		%dot.setNodeColor("ALL", %cl.aeLaserColor);

// 	messageClient(%cl, '', "<color:" @ rgb2hex(%col) @ ">Set laser color.");

// 	$AEClient_LaserColor[%cl.getBLID()] = %col SPC "1";

// 	export("$AEClient_*", "config/server/aebasecl.cs");
// }

// function serverCmdAToggle(%cl)
// {
// 	if(%cl.attachOff)
// 	{
// 		%cl.attachOff = false;
// 		messageClient(%cl, '', "\c2Enabled lasers and flashlights.");
// 	}
// 	else
// 	{
// 		%cl.attachOff = true;
// 		messageClient(%cl, '', "Disabled lasers and flashlights.");
// 	}
// }

function hasItemOnList(%string,%item)
{
	for(%i=0;%i<getWordCount(%string);%i++)
	{
		if(getWord(%string,%i) $= %item)
			return 1;
	}
	return 0;
}

function Normal2Rotation(%normal)
{
	if(getWord(%normal, 2) == 1 || getWord(%normal, 2) == -1)
	{
			%rotAxis = vectorNormalize(vectorCross(%normal, "0 1 0"));
	}
	else
	{
			%rotAxis = vectorNormalize(vectorCross(%normal, "0 0 1"));
	}

	%initialAngle = mACos(vectorDot(%normal, "0 0 1"));
	%rotation = %rotAxis SPC mRadtoDeg(%initialAngle);


	return %rotation;
}

function Player::aeLaserLoop(%pl, %img)
{
	if(!isObject(%pl) || !isObject(%img))
		return;

	cancel(%pl.aeLaser);

	if(%pl.getDamagePercent() >= 1.0)
		return;

	%off = %img.laserOffStates;

	// if(%img.scopeSway)
	// {
	// 	if(getSimTime() - %pl.lastSwayTime > 3500)
	// 	{
	// 		%pl.spawnExplosion(AESwayProjectile, "0.06 0.06 0.06");
	// 		%pl.lastSwayTime = getSimTime();
	// 	}
	// }

	if((getWordCount(%off) <= 0 || !hasItemOnList(%off, %pl.getImageState(0))) && (!%pl.Client.attachOff || %img.ignoreAToggle))
	{
		//1 if(!isObject(%cl = %pl.Client) || %cl.aeLaserColor $= "")
		// 	%cl.aeLaserColor = "1 0 0 1";

		// if(isObject(%cl) && !%cl.IsA("AIPlayer") && (%col = $AEClient_LaserColor[%cl.getBLID()]) !$= "")
		// 	%cl.aeLaserColor = %col;

		if(%img.laserDistance > 1 || %img.flashlightDistance > 1)
		{
			%vec = %pl.getMuzzleVector(0);

			if(getSimTime() - %pl.lastShotTime[%img] < %img.spreadReset)
				%vec = vectorAdd(%vec, "0 0 " @ %pl.climb[%img]);

			%pos = %pl.getMuzzlePoint(0);
			%mask = $TypeMasks::StaticShapeObjectType | $TypeMasks::FxBrickObjectType | $TypeMasks::VehicleObjectType | $TypeMasks::TerrainObjectType | $TypeMasks::PlayerObjectType;

			if(%img.laserDistance > 1)
			{
				%end = vectorAdd(%pos, vectorScale(%vec, %img.laserDistance));
				%ray = containerRayCast(%pos, %end, %mask, %pl);

				if(%ray)
				{
					%point = getWords(%ray, 1, 3);
					%norm = getWords(%ray, 4, 6);
					
					%obj = firstWord(%ray);

					if(%obj.IsA("Player") || %obj.IsA("AIPlayer"))
					{
						%eye = %obj.getEyeVector();

						if(vectorDot(%eye, %vec) < 0.4)
						{
							%curr = %obj.getDamageFlash();
							if(%curr < $Pref::AEBase::laserBlind)
								%obj.setDamageFlash(mClampF(%curr + 0.13, 0, $Pref::AEBase::laserBlind));
						}
					}

					cancel(%pl.aeLaserCleanup);

					if(!isObject(%pl.laserDot))
					{
						%pl.laserDot = new StaticShape()
						{
							dataBlock = AELaserDotShape;
						};

						%pl.laserDot.setNodeColor("ALL", %img.laserColor);

						%pl.laserDot.startFade(1,0,1);

						%sx = mClampF(getWord(%img.laserSize, 0), 0.2, 6);
						%sy = mClampF(getWord(%img.laserSize, 1), 0.2, 6);
						%sz = mClampF(getWord(%img.laserSize, 2), 0.2, 6);

						%pl.laserDot.setScale(%sx SPC %sy SPC %sz);

						missionCleanup.add(%pl.laserDot);
					}

					if(%img.laserFade !$= "" && %img.laserFade < %img.laserDistance)
					{
						%alpha = getWord(%img.laserColor, 3);
						if((%dist = vectorDist(%pos, %point)) > %img.laserFade)
						{
							%mult = (%dist - %img.laserFade) / (%img.laserDistance - %img.laserFade);
							%alpha = mFloatLerp(%alpha, 0, 1 - %mult);

							%pl.laserDot.setNodeColor("ALL", getWords(%img.laserColor, 0, 2) SPC %alpha);
						}
						else
						{
							%pl.laserDot.setNodeColor("ALL", %img.laserColor);
						}
					}

					%rot = Normal2Rotation(%norm);
					%ang = mDegToRad(getWord(%rot, 3));

					%pl.laserDot.setTransform(%point SPC getWords(%rot, 0, 2) SPC %ang);

					%pl.aeLaserCleanup = %pl.laserDot.schedule(100, delete);
				}
			}

			if(%img.flashlightDistance > 1)
			{
				%end = vectorAdd(%pos, vectorScale(%vec, %img.flashlightDistance));
				%ray = containerRayCast(%pos, %end, %mask, %pl);

				if(%ray)
				{
					%normal = getWords(%ray, 4, 7);
					%point = getWords(%ray, 1, 3);
					%point = vectorAdd(%point, vectorScale(%normal, 0.75));

					%obj = firstWord(%ray);

					if(%obj.IsA("Player") || %obj.IsA("AIPlayer"))
					{
						%eye = %obj.getEyeVector();

						if(vectorDot(%eye, %vec) < 0.4)
						{
							%curr = %obj.getWhiteout();
							if(%curr < $Pref::AEBase::flashlightBlind)
								%obj.setWhiteout(mClampF(%curr + 0.13, 0, $Pref::AEBase::flashlightBlind));
						}
					}
				}
				else
					%point = %end;

				cancel(%pl.aeLightCleanup);

				if(!isObject(%pl.aeFlashLight))
				{
					%pl.aeFlashLight = new FxLight()
					{
						datablock = AEPlayerFlashlight;
						player = %player;

						iconSize = 1;
						enable = 1;
					};
				}

				%pl.aeFlashLight.setTransform(%point);
				%pl.aeFlashLight.reset();

				%pl.aeLightCleanup = %pl.aeFlashLight.schedule(100, delete);
			}
		}
	}

	%pl.aeLaser = %pl.schedule(50, aeLaserLoop, %img);
}

function strMultiline(%str, %len)
{
	if(trim(%len) $= "") %len = 256;

	%str = trim(%str);

	if((%cts = getRecordCount(%str)) > 1)
	{
		%stri = "";
		for(%i = 0; %i < %cts; %i++)
			%stri = %stri NL strMultiline(getRecord(%str, %i), %len);

		return trim(%stri);
	}

	%off = 0;
	%last = -1;

	while((%pos = stripos(%str, " ", %off)) != -1)
	{
		if(%pos <= %len)
		{
			%off = %pos+1;
			%last = %pos;
		}
		else
			break;
	}

	if(%last != -1)
		%line = getSubStr(%str, 0, %last);
	else
		%line = %str;

	if(%last < strLen(%str) && %last != -1)
		return trim(%line NL strMultiline(getSubStr(%str, %last, strLen(%str)), %len));

	return %line;
}

function serverCmdGunInfo(%client)
{
	%player = %client.player;
	if(!isObject(%player))
			return;

	%image = %player.getMountedImage(0);
	%item = %image.item;
	%format = "<font:arial bold:20>\c6";

	if(!%item.AEBase)
	{
		messageClient(%client, '', "You must be holding an AEBase weapon to use this command!");
		return;
	}

	%low = "FF3333";
	%med = "FFFF33";
	%high = "33FF33";

	%col = "<color:";

	%damageval = %image.projectileDamage * $Pref::AEBase::playerDamageMult;
	%damagefarval = %image.projectileDamage * %image.projectileFalloffDamage * $Pref::AEBase::playerDamageMult;
	%headshotval = %image.projectileHeadshotMult * $Pref::AEBase::playerHeadshotMult;
	%damageheadval = %damageval * %headshotval;
	%spreadval = %image.spreadMin * $Pref::AEBase::playerAccuracyMult;
	%spreadmaxval = %image.spreadMax * $Pref::AEBase::playerAccuracyMult;

	%val = mClampF(%image.projectileVelocity, 0, 200) / 200; // ae i hate you die die die
	%velocitycol = (%val > 0.3333 ? (%val > 0.6667 ? %high : %med) : %low);

	%val = mClampF(%damageval, 0, 100) / 100;
	%damagecol = (%val > 0.3333 ? (%val > 0.6667 ? %high : %med) : %low);

	%val = mClampF(%damagefarval, 0, 100) / 100;
	%damagefarcol = (%val > 0.3333 ? (%val > 0.6667 ? %high : %med) : %low);

	%val = mClampF(%damageheadval, 0, 100) / 100;
	%damageheadcol = (%val > 0.3333 ? (%val > 0.6667 ? %high : %med) : %low);

	%val = mClampF(%spreadval, 0, 800) / 800;
	%spreadcol = (%val > 0.3333 ? (%val > 0.6667 ? %low : %med) : %high);

	%val = mClampF(%spreadmaxval, 0, 800) / 800;
	%spreadmaxcol = (%val > 0.3333 ? (%val > 0.6667 ? %low : %med) : %high);

	%val = mClampF(%item.rpm, 0, 600) / 600;
	%rpmcol = (%val > 0.3333 ? (%val > 0.6667 ? %high : %med) : %low);

	%damagecol = %col @ %damagecol @ ">";
	%damagefarcol = %col @ %damagefarcol @ ">";
	%damageheadcol = %col @ %damageheadcol @ ">";
	%velocitycol = %col @ %velocitycol @ ">";
	%spreadcol = %col @ %spreadcol @ ">";
	%spreadmaxcol = %col @ %spreadmaxcol @ ">";
	%rpmcol = %col @ %rpmcol @ ">";

	//messageClient(%client, '', "<font:arial:18>\c6" @ "Gun Info:");
	messageClient(%client, '', "<font:consolas bold:36><color:" @ rgb2hex(%item.uiColor) @ ">" @ %item.uiName);
	messageClient(%client, '', %format @ "Chambered in<font:arial:20>\c6: \c2" @ %item.AEAmmo @ "\c6x " @ %item.AEType.AEAmmo @ "\c6 Rounds");
	messageClient(%client, '', %format @ "Fire rate<font:arial:20>\c6: " @ %rpmcol @ %item.RPM @ "\c6 rpm");
	messageClient(%client, '', %format @ "Muzzle velocity<font:arial:20>\c6: " @ %velocitycol @ %image.projectileVelocity @ "\c6 u/s");

	if(%image.projectileFalloffDamage !$= "" && %image.projectileFalloffStart !$= "" && %image.projectileFalloffEnd !$= "")
	{
		messageClient(%client, '', %format @ "Direct damage<font:arial:20>\c6: " @
		(%image.projectileCount > 1 ? "\c2" @ %image.projectileCount @ "\c6x " : "") @ %damagecol @ %damageval @ "\c6 dmg at \c2" @ %image.projectileFalloffStart * 2 @ " \c6st to" @
		(%image.projectileCount > 1 ? " \c2" @ %image.projectileCount @ "\c6x " : " ") @ %damagefarcol @ %damagefarval @ "\c6 dmg at \c2" @ %image.projectileFalloffEnd * 2 @
		" \c6st <font:arial:16>(" @ %damageheadcol @ %damageheadval @ "\c6 head dmg)");
	}
	else
	{
		messageClient(%client, '', %format @ "Direct damage<font:arial:20>\c6: " @
		(%image.projectileCount > 1 ? "\c2" @ %image.projectileCount @ "\c6x " : "") @ %damagecol @ %damageval @ "\c6 dmg <font:arial:16>\c6(" @ %damageheadcol @ %damageheadval @ "\c6 head dmg)");
	}

	messageClient(%client, '', %format @ "Bullet Spread<font:arial:20>\c6: "
	@ %spreadcol @ mFloatLength(%spreadval / 10, 1) @ "\c6 - " @ %spreadmaxcol @ mFloatLength(%spreadmaxval / 10, 1) @ "<font:arial:16>\c6 (" @ %item.recoil @ " Recoil)");

	if(trim(%desc = %item.description) !$= "")
	{
		%string = %format @ "Description<font:arial:20>\c6: " @ %item.description;

		for(%i = 0; %i < getRecordCount(%string); %i++)
			messageClient(%client, '', "<font:arial:20>\c6" @ getRecord(%string, %i));
	}
}

function serverCmdGunHelp(%cl) { serverCmdGunInfo(%cl); }
function serverCmdGunStat(%cl) { serverCmdGunInfo(%cl); }
function serverCmdGunStats(%cl) { serverCmdGunInfo(%cl); }

function serverCmdAeHelp(%cl)
{
	messageClient(%cl, '', "\c2AEBase by Oxy and aebaadcode");
	messageClient(%cl, '', "\c2/guninfo\c6 - shows you the stats of the gun you are holding");
	messageClient(%cl, '', "\c2/ztoggle\c6 - toggles smooth zoom");
	// messageClient(%cl, '', "\c2/atoggle\c6 - toggles mounted attachments");
	messageClient(%cl, '', "\c2/adshold\c6 - toggles ADS holding");
	messageClient(%cl, '', "\c2/fov NUMBER\c6 - change your default fov");
	messageClient(%cl, '', "\c2/dropammo AMMOTYPE NUMBER\c6 - drop your reserve ammo (drops current weapon's reserve if ammo type isn't specified)");
	messageClient(%cl, '', "\c2/listammo\c6 - shows you your reserve ammo count");
}

function serverCmdZToggle(%cl)
{
	if(%cl.zoomLerp)
	{
		%cl.zoomLerp = false;
		messageClient(%cl, '', "\c2Disabled smooth zoom.");
	}
	else
	{
		%cl.zoomLerp = true;
		messageClient(%cl, '', "\c2Enabled smooth zoom.");
	}

	$AEClient_NoZoom[%cl.getBLID()] = %cl.zoomLerp;
	export("$AEClient_*", "config/server/aebasecl.cs");
}

function serverCmdADSHold(%cl)
{
	if(%cl.adsHold)
	{
		%cl.adsHold = false;
		messageClient(%cl, '', "\c2Disabled ADS holding.");
	}
	else
	{
		%cl.adsHold = true;
		messageClient(%cl, '', "\c2Enabled ADS holding");
	}

	$AEClient_ADSHold[%cl.getBLID()] = %cl.adsHold;
	export("$AEClient_*", "config/server/aebasecl.cs");
}

function serverCmdADSToggle(%cl) { serverCmdADSHold(%cl); }

package MinimumDetonationRange //borrowed from rallypack directly, i take no credit for this =)
{
	function ProjectileData::onExplode(%this, %obj, %slot)
	{
		if(isObject(%this.activatedProjectile) && !%obj.rwep_dontActivate)
		{
			%initialPosition = %obj.getPosition();
			%initialVelocity = vectorScale(vectorNormalize(%obj.getVelocity()), %this.activatedProjectile.muzzleVelocity);

			%projectile = new Projectile ()
			{
				dataBlock = %this.activatedProjectile;
				initialVelocity = %initialVelocity;
				initialPosition = %initialPosition;
				sourceObject = %obj.sourceObject;
				client = %obj.client;
				r_noImpact = %obj.r_noImpact;
			};
			MissionCleanup.add(%projectile);
		}
		Parent::onExplode(%this, %obj, %slot);
	}

	function ProjectileData::onCollision(%this, %obj, %col, %fade, %pos, %normal, %velocity)
	{
		if(%this.destroyOnBounce)
		{
			%obj.rwep_dontActivate = true;

			if(isObject(%this.bounceDestroyProjectile))
			{
				%projectile = new Projectile ()
				{
					dataBlock = %this.bounceDestroyProjectile;
					initialPosition = %pos;
					initialVelocity = 0;
					sourceObject = %obj.sourceObject;
					client = %obj.client;
					r_noImpact = %obj.r_noImpact;
					rwep_dontActivate = true;
				};
				MissionCleanup.add(%projectile);
				%projectile.schedule(0, explode);
			}

			if(%this.deleteOnBounce)
				%obj.delete();
			else
				%obj.explode();
		}
		Parent::onCollision(%this, %obj, %col, %fade, %pos, %normal, %velocity);
	}
};
activatePackage(MinimumDetonationRange);

function Player::getLookVector(%pl)
{
	%fvec = %pl.getForwardVector();
	%fX = getWord(%fvec,0);
	%fY = getWord(%fvec,1);

	%evec = %pl.getEyeVector();
	%eX = getWord(%evec,0);
	%eY = getWord(%evec,1);
	%eZ = getWord(%evec,2);

	%eXY = mSqrt(%eX*%eX+%eY*%eY);

	%aimVec = %fX*%eXY SPC %fY*%eXY SPC %eZ;
	return %aimVec;
}

function Player::getRightVector(%pl)
{
	%fwd = %pl.getForwardVector();
	%rgt = getWord(%fwd, 1) SPC getWord(%fwd, 0)*-1 SPC getWord(%fwd, 2);
	return %rgt;
}

function SimObject::IsA(%obj, %type)
{
	return %obj.getClassName() $= %type;
}

function gameConnection::DropInventory(%client)
{
    if(isObject(%client.player))
    {
        for(%i=0;%i<%client.player.getDatablock().maxTools;%i++)
        {
            %item = %client.player.tool[%i];
            if(isObject(%item))
            {
                %pos = %client.player.getPosition();
                %rand = getRandom() * 3.14159 * 20;
                %x = mSin(%rand);
                %y = mCos(%rand);
                %offset = vectorNormalize(%x SPC %y);
                %vec = %client.player.getVelocity();
                %item = new Item()
                {
                    dataBlock = %item;
                    position = vectorAdd(%pos, %offset);
                };
                %itemVec = %vec;
                %itemVec = vectorAdd(%itemVec,"0 0 5");
                %item.BL_ID = %client.BL_ID;
                %item.minigame = %client.minigame;
                %item.spawnBrick = -1;
                %item.setVelocity(%itemVec);
                %item.schedulePop();
            }
            %client.player.tool[%i] = "";
        }
    }
    Parent::DropInventory(%client);
}

//we need the gun add-on for this, so force it to load
%error = ForceRequiredAddOn("Weapon_Gun");

if(%error == $Error::AddOn_NotFound)
{
   //we don't have the gun, so we're screwed
   error("ERROR: AEBase - required add-on Weapon_Gun not found");
}
else
{
   exec("./Support_EffectDatablocks.cs");
   exec("./Sounds/Sounds.cs");
   exec("./Support_AmmoReserve.cs");
   exec("./Support_RaycastingWeapons.cs");
   exec("./Support_Suppression.cs");
   exec("./Support_StaticHitscan.cs");
   exec("./Item_Ammo.cs");

 //exec("./Weapon_Mac10.cs");
 //exec("./Weapon_Mac10Silenced.cs");
 //exec("./Weapon_HKM4.cs");
 //  exec("./Weapon_Flashlight.cs");
 //  exec("./Weapon_LaserPointer.cs");
// exec("./Weapon_BLShotgun.cs");
}

function Player::aeplayThread(%this, %slot, %thread)
{
	if(%this.getDamagePercent() < 1)
	%this.playThread(%slot, %thread);
}

function GameConnection::stateHelp(%cl) // for dev
{
	cancel(%cl.shs);

	if(isObject(%pl = %cl.player))
	{
		if(isObject(%img = %pl.getMountedImage(0)))
		{
			%st = %pl.getImageState(0);
			if(%pl.getImageAmmo(0)) %str = "<color:44FF44>ammo";
			else %str = "<color:FF4444>noammo";
			if(%pl.getImageLoaded(0)) %str = %str @ " <color:44FF44>loaded";
			else %str = %str @ " <color:FF4444>empty";

			%cl.centerPrint("<font:arial:14><color:FFFFFF>state: " @ %st @ "<br>img: " @ %img @ "<br>" @ %str, 1);
			if(%cl.lastState !$= %st)
			{
				%cl.lastState = %st;
				%cl.chatMessage("\c6new state: \c3" @ %st @ "\c6 (" @ %str @ "\c6)");
			}
		}
	}

	%cl.shs = %cl.schedule(5, stateHelp);
}
