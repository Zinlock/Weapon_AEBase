// Repurposed code from Oxy's pretty much scrapped BKT2 pack

function Player::aeAmmoCheck(%pl)
{
	%img = %pl.getMountedImage(0);
	%itm = %img.item;
	%idx = %pl.currTool;

	%aIdx = %img.AEUseAmmo;
	%type = %itm.AEType[%aIdx];

	if(%pl.AEInfAmmo)
		return 2;

	if(!%itm.AENoReserve[%aIdx])
	{
		if(!isObject(%type))
		{
			warn("invalid AE item" SPC %itm SPC "(ammo type does not exist)");
			return;
		}
		else if(%type.aeAmmo $= "ALL")
		{
			warn("invalid AE item" SPC %itm SPC "(ammo type is set to ALL)");
			return;
		}
	}
	
	if(%itm.aeAmmo[%aIdx] <= 0 || %itm.aeAmmo[%aIdx] $= "")
	{
		warn("invalid AE item" SPC %itm SPC "(invalid ammo cap)");
		return;
	}

	if(%pl.AEReloading)
	{
		%pl.AEReloading = false;
		return 0;
	}

	if(%pl.aeAmmo[%idx, %aIdx] >= %itm.aeAmmo[%aIdx])
		return 2; // full
	else if(%pl.aeAmmo[%idx, %aIdx] > 0)
		return 1; // loaded
	else
		return 0; // empty
}

function Player::AEReserveCheck(%pl)
{
	if(%pl.IsA("AIPlayer"))
		return 2;

	%img = %pl.getMountedImage(0);
	%itm = %img.item;
	%idx = %pl.currTool;

	%aIdx = %img.AEUseAmmo;
	%type = %itm.AEType[%aIdx];

	if(!%itm.AENoReserve[%aIdx])
	{
		if(!isObject(%type))
		{
			warn("invalid AE item" SPC %itm SPC "(ammo type does not exist)");
			return;
		}
		else if(%type.aeAmmo $= "ALL")
		{
			warn("invalid AE item" SPC %itm SPC "(ammo type is set to ALL)");
			return;
		}
	}

	if(%itm.aeAmmo[%aIdx] <= 0 || %itm.aeAmmo[%aIdx] $= "")
	{
		warn("invalid AE item" SPC %itm SPC "(invalid ammo cap)");
		return;
	}

	if(%pl.aeAmmo[%idx, %aIdx] $= "")
		%pl.aeAmmo[%idx, %aIdx] = %itm.aeAmmo[%aIdx];

	if($Pref::AEBase::ReserveAmmo && !%itm.AENoReserve[%aIdx])
	{
		if(%pl.AEReserve[%type] >= %itm.aeAmmo[%aIdx])
			return 2; // full
		else if(%pl.AEReserve[%type] > 0)
			return 1; // loaded
		else
			return 0; // empty
	}
	else
		return 2;
}

function Player::AEMagReload(%pl)
{
	%img = %pl.getMountedImage(0);
	%itm = %img.item;
	%idx = %pl.currTool;

	%aIdx = %img.AEUseAmmo;
	%type = %itm.AEType[%aIdx];

	if(!%itm.AENoReserve[%aIdx])
	{
		if(!isObject(%type))
		{
			warn("invalid AE item" SPC %itm SPC "(ammo type does not exist)");
			return;
		}
		else if(%type.aeAmmo $= "ALL")
		{
			warn("invalid AE item" SPC %itm SPC "(ammo type is set to ALL)");
			return;
		}
	}
	
	if(%itm.aeAmmo[%aIdx] <= 0 || %itm.aeAmmo[%aIdx] $= "")
	{
		warn("invalid AE item" SPC %itm SPC "(invalid ammo cap)");
		return;
	}

	if($Pref::AEBase::ReserveAmmo && !%pl.IsA("AIPlayer") && !%itm.AENoReserve[%aIdx])
	{
		if(%pl.AEReserve[%type] > %itm.aeAmmo[%aIdx])
		{
			%pl.AEReserve[%type] -= %itm.aeAmmo[%aIdx] - %pl.aeAmmo[%idx, %aIdx];
			%pl.aeAmmo[%idx, %aIdx] = %itm.aeAmmo[%aIdx];
			return 2;
		}
		else if(%pl.AEReserve[%type] > 0)
		{
			%amt = %itm.aeAmmo[%aIdx] - %pl.AEAmmo[%idx, %aIdx];
			%amt = mClamp(%amt, 0, %pl.AEReserve[%type]);
			%pl.aeAmmo[%idx, %aIdx] += %amt;
			%pl.AEReserve[%type] -= %amt;
			return 1;
		}
		else
			return 0;
	}
	else
	{
		%pl.aeAmmo[%idx, %aIdx] = %itm.aeAmmo[%aIdx];
		return 2;
	}
}

function Player::AEUnloadMag(%pl)
{
	%img = %pl.getMountedImage(0);
	%itm = %img.item;
	%idx = %pl.currTool;

	%aIdx = %img.AEUseAmmo;
	%type = %itm.AEType[%aIdx];

	if(!%itm.AENoReserve[%aIdx])
	{
		if(!isObject(%type))
		{
			warn("invalid AE item" SPC %itm SPC "(ammo type does not exist)");
			return;
		}
		else if(%type.aeAmmo $= "ALL")
		{
			warn("invalid AE item" SPC %itm SPC "(ammo type is set to ALL)");
			return;
		}
	}
	
	if(%itm.aeAmmo[%aIdx] <= 0 || %itm.aeAmmo[%aIdx] $= "")
	{
		warn("invalid AE item" SPC %itm SPC "(invalid ammo cap)");
		return;
	}

	if(%pl.aeAmmo[%idx, %aIdx] <= 0)
		return 0;

	if($Pref::AEBase::ReserveAmmo && !%pl.IsA("AIPlayer") && !%itm.AENoReserve[%aIdx])
	{
		%ammo = %pl.aeAmmo[%idx, %aIdx];
		%final = %pl.aeReserve[%type] + %ammo;

		if(%final > %type.aeMax)
		{
			%amt = %final - %type.aeMax;
			
			%itm = new Item()
			{
				dataBlock = %type;
				position = %pl.getHackPosition();
				canPickup = true;
				static = false;
				minigame = getMinigameFromObject(%pl);
				bl_id = %pl.Client.getBLID();
			};

			%vel = vectorAdd(vectorScale(%pl.getEyeVector(), 5), "0 0 2");

			%itm.setCollisionTimeout(%pl);
			%itm.setVelocity(%vel);
			%itm.schedulePop();
			%itm.aeAmmo = %amt;
			%itm.setShapeName(strreplace(%type.uiName, "A: ", "") SPC "(" @ %amt @ ")");
			%itm.setShapeNameDistance(15);

			MissionCleanup.add(%itm);
		
			%pl.aeReserve[%type] = %type.aeMax;
		}
		else
			%pl.aeReserve[%type] = %final;
	}

	%pl.aeAmmo[%idx, %aIdx] = 0;
	return 1;
}

function Player::AEUnloadShell(%pl)
{
	%img = %pl.getMountedImage(0);
	%itm = %img.item;
	%idx = %pl.currTool;

	%aIdx = %img.AEUseAmmo;
	%type = %itm.AEType[%aIdx];

	if(!%itm.AENoReserve[%aIdx])
	{
		if(!isObject(%type))
		{
			warn("invalid AE item" SPC %itm SPC "(ammo type does not exist)");
			return;
		}
		else if(%type.aeAmmo $= "ALL")
		{
			warn("invalid AE item" SPC %itm SPC "(ammo type is set to ALL)");
			return;
		}
	}
	
	if(%itm.aeAmmo[%aIdx] <= 0 || %itm.aeAmmo[%aIdx] $= "")
	{
		warn("invalid AE item" SPC %itm SPC "(invalid ammo cap)");
		return;
	}

	if(%pl.aeAmmo[%idx, %aIdx] <= 0)
		return 0;

	if($Pref::AEBase::ReserveAmmo && !%pl.IsA("AIPlayer") && !%itm.AENoReserve[%aIdx])
	{
		%final = %pl.aeReserve[%type] + 1;

		if(%final > %type.aeMax)
		{
			%itm = new Item()
			{
				dataBlock = %type;
				position = %pl.getHackPosition();
				canPickup = true;
				static = false;
				minigame = getMinigameFromObject(%pl);
				bl_id = %pl.Client.getBLID();
			};

			%vel = vectorAdd(vectorScale(%pl.getEyeVector(), 5), "0 0 2");

			%itm.setCollisionTimeout(%pl);
			%itm.setVelocity(%vel);
			%itm.schedulePop();
			%itm.aeAmmo = 1;
			%itm.setShapeName(strreplace(%type.uiName, "A: ", "") SPC "(1)");
			%itm.setShapeNameDistance(15);

			MissionCleanup.add(%itm);
		
			%pl.aeReserve[%type] = %type.aeMax;
		}
		else
			%pl.aeReserve[%type] = %final;
	}

	%pl.aeAmmo[%idx, %aIdx] -= 1;
	return 1;
}

function Player::AEShellReload(%pl)
{
	%img = %pl.getMountedImage(0);
	%itm = %img.item;
	%idx = %pl.currTool;

	%aIdx = %img.AEUseAmmo;
	%type = %itm.AEType[%aIdx];

	if(!%itm.AENoReserve[%aIdx])
	{
		if(!isObject(%type))
		{
			warn("invalid AE item" SPC %itm SPC "(ammo type does not exist)");
			return;
		}
		else if(%type.aeAmmo $= "ALL")
		{
			warn("invalid AE item" SPC %itm SPC "(ammo type is set to ALL)");
			return;
		}
	}
	
	if(%itm.aeAmmo[%aIdx] <= 0 || %itm.aeAmmo[%aIdx] $= "")
	{
		warn("invalid AE item" SPC %itm SPC "(invalid ammo cap)");
		return;
	}

	if($Pref::AEBase::ReserveAmmo && !%pl.IsA("AIPlayer") && !%itm.AENoReserve[%aIdx])
	{
		if(%pl.AEReserve[%type] > 0)
		{
			%pl.AEReserve[%type]--;
			%pl.aeAmmo[%idx, %aIdx]++;
			if(%pl.aeAmmo[%idx, %aIdx] >= %itm.aeAmmo[%aIdx])
				return 2;
			else
				return 1;
		}
		else
			return 0;
	}
	else
	{
		if(%pl.aeAmmo[%idx, %aIdx] < %itm.aeAmmo[%aIdx])
			%pl.aeAmmo[%idx, %aIdx]++;

		if(%pl.aeAmmo[%idx, %aIdx] >= %itm.aeAmmo[%aIdx])
			return 2;
		else
			return 1;
	}
}

function WeaponImage::AEPreMagCheck(%img, %pl, %slot)
{
	%pl.setImageAmmo(%slot, %pl.aeAmmoCheck() == 2);
}

function WeaponImage::AEPreMagAmmoCheck(%img, %pl, %slot)
{
	if(%pl.AEReserveCheck() > 0)
		%pl.setImageAmmo(%slot, %pl.aeAmmoCheck() == 2);
	else
		%pl.setImageAmmo(%slot, %pl.aeAmmoCheck());
}

function WeaponImage::AEPreAmmoCheck(%img, %pl, %slot)
{
	%pl.setImageAmmo(%slot, %pl.aeAmmoCheck());
}

function WeaponImage::AEPreLoadAmmoCheck(%img, %pl, %slot)
{
	%pl.setImageLoaded(%slot, %pl.aeAmmoCheck());
}

function WeaponImage::AEPreReserveCheck(%img, %pl, %slot)
{
	%pl.setImageAmmo(%slot, %pl.AEReserveCheck());
}

function WeaponImage::AEPreLoadReserveCheck(%img, %pl, %slot)
{
	%pl.setImageLoaded(%slot, %pl.AEReserveCheck());
}

function WeaponImage::AEPreLoadAmmoReserveCheck(%img, %pl, %slot)
{
	%res = %pl.AEReserveCheck();
	%pl.setImageLoaded(%slot, %res);
	if(!%res)
		%pl.setImageLoaded(%slot, %pl.aeAmmoCheck());
}

function strJaroDistance(%s1, %s2)
{
	if (%s1 $= %s2)
		return 1;

	%len1 = strlen(%s1);
	%len2 = strlen(%s2);
	if (%len1 == 0 || %len2 == 0)
		return 0;

	%maxDist = mFloor(getMax(%len1, %len2)/2) - 1;
	%match = 0;

	for (%i = 0; %i < %len1; %i++) {
		for (%j = getMax(0, %i - %maxDist); %j < getMin(%len2, %i + %maxDist + 1); %j++) {
			if (getSubStr(%s1, %i, 1) $= getSubStr(%s2, %j, 1) && %hash_s2[%j] == 0) {
				%hash_s1[%i] = 1;
				%hash_s2[%j] = 1;
				%match++;
				break;
			}
		}
	}

	if (%match == 0)
		return 0;

	%t = 0;
	%point = 0;

	for (%i = 0; %i < %len1; %i++) {
		if (%hash_s1[%i]) {
			while (%hash_s2[%point] == 0)
				%point++;

			if (getSubStr(%s1, %i, 1) != getSubStr(%s2, %point, 1))
				%t++;

			%point++;
		}
	}

	return ((%match/%len1) + (%match/%len2) + (%match - %t)/(%match))/3;
}

function strJaroWinklerDistance(%s1, %s2)
{
	if (%s1 $= %s2)
		return 1;

	%jaroDist = strJaroDistance(%s1, %s2);
	if (%jaroDist > 0.7) {
		%len1 = strlen(%s1);
		%len2 = strlen(%s2);
		%min = getMin(%len1, %len2);

		%prefix = 0;
		for (%i = 0; %i < %min; %i++) {
			if (getSubStr(%s1, %i, 1) $= getSubStr(%s2, %i, 1))
				%prefix++;
			else
				break;
		}

		%prefix = getMin(4, %prefix);
		%jaroDist += 0.1*%prefix*(1 - %jaroDist);
	}

	return %jaroDist;
}

function AEBuildAmmoStrings()
{
	deleteVariables("$AEStringCache*");

	%set = nameToID("aeAmmoSet");
	if (%set < 0)
		AEMakeAmmo();
	%set = nameToID("aeAmmoSet");

	if (!isObject(aeAmmoStringSet))
		new SimSet(aeAmmoStringSet);
	else
		aeAmmoStringSet.clear();

	%strs = nameToID("aeAmmoStringSet");
	%nstrs = -1;

	%count = %set.getCount();
	for (%i = 0; %i < %count; %i++) {
		%type = %set.getObject(%i);
		if (%type.aeAmmo $= "ALL")
			continue;

		%uiName = trim(strReplace(%type.uiName, "A: ", ""));
		%words = getWordCount(%uiName);
		%abbr = "";

		for (%j = 0; %j < %words; %j++) {
			%word = getWord(%uiName, %j);
			%strs.str[%nstrs++, 0] = %word;
			%strs.str[%nstrs, 1] = %type;
		}

		%first = firstWord(%uiName);
		if (%xpos = stripos(%first, "x")) {
			%first = getSubStr(%first, %xpos + 1, 999);
			%strs.str[%nstrs++, 0] = %first;
			%strs.str[%nstrs, 1] = %type;
		}

		if (stripChars(%first, "0123456789") !$= %first) {
			%first = %first+0;
			%abbr = %first;
		}
		else {
			%first = getSubStr(%first, 0, 1);
			%abbr = getSubStr(%first, 0, 1);
		}

		for (%j = 1; %j < %words; %j++)
			%abbr = %abbr @ getSubStr(getWord(%uiName, %j), 0, 1);

		%strs.str[%nstrs++, 0] = %abbr;
		%strs.str[%nstrs, 1] = %type;

		%strs.str[%nstrs++, 0] = getSubStr(%abbr, strlen(%first), 999);
		%strs.str[%nstrs, 1] = %type;
	}

	%strs.count = %nstrs + 1;
}

function serverCmdListAmmo(%cl, %a0, %a1, %a2, %a3, %a4, %a5, %a6, %a7)
{
	if(!$Pref::AEBase::ReserveAmmo)
		return;

	%pl = %cl.player;
	if(!isObject(%pl))
		return;

	if(!isObject(aeAmmoSet))
		AEMakeAmmo();

	messageClient(%cl, '', "<font:consolas bold:36>\c6AMMO LIST");

	%set = nameToID("aeAmmoSet");
	%count = %set.getCount();

	%numDisplayed = 0;
	for(%i = 0; %i < %count; %i++)
	{
		%type = %set.getObject(%i);
		if((%amt = %pl.aeReserve[%type]) > 0)
		{
			%max = %type.aeMax;
			%color = "<color:" @ rgb2hex(RGBLerp("0 1 0", "1 0 0", %amt/%max)) @ ">";
			%uiName = strreplace(%type.uiName, "A: ", "");
			messageClient(%cl, '', '<font:arial:18>%1%2\c6 - <font:arial bold:18>\c6%3', %color, %amt, %uiname);
			%numDisplayed++;
		}
	}

	if(%numDisplayed <= 0)
		messageClient(%cl, '', "<font:arial bold:18>\c6Reserve empty");
}

function serverCmdDropAmmo(%cl, %a0, %a1, %a2, %a3, %a4, %a5, %a6, %a7) // TODO: un-fuck this to work with the new multi-ammo type setup
{
	if(!$Pref::AEBase::ReserveAmmo)
		return;

	%pl = %cl.player;
	if(!isObject(%pl))
		return;

	if(!isObject(aeAmmoSet))
		AEMakeAmmo();

	%time = $Sim::Time;
	if(%time - %cl.lastDropAmmoTime < 1)
	{
		messageClient(%cl, '', "\c2You must wait a second between uses");
		return;
	}
	%cl.lastDropAmmoTime = %time;

	%usage = "\c2/dropAmmo AMOUNT\c6 or \c2 /dropAmmo AMMO_TYPE AMOUNT";

	for(%i = 0; %i < 8; %i++)
		%data = %data SPC %a[%i];
	%data = trim(%data);

	%words = getWordCount(%data);
	if(%words == 0)
	{
		messageClient(%cl, '', %usage);
		return;
	}

	%amt = getWord(%data, %words - 1);

	if(atoi(%amt) !$= %amt)
	{
		messageClient(%cl, '', %usage);
		return;
	}

	if(%amt <= 0)
	{
		messageClient(%cl, '', '\c2The amount of ammo must be greater than 0');
		return;
	}

	if(%words == 1)
	{
		%ammoType = %pl.tool[%pl.currTool].aeType;
		if(!isObject(%ammoType))
		{
			messageClient(%cl, '', "\c2You must be holding a weapon to use the command like this");
			return;
		}
	}
	else
	{
		if (!isObject(aeAmmoStringSet))
			AEBuildAmmoStrings();

		%uiName = getWords(%data, 0, %words - 2);
		%uiName = getSubStr(%uiName, 0, 20);

		%set = nameToID("aeAmmoStringSet");
		%count = %set.count;

		if(!isObject($AEStringCache[%uiName]))
		{
			%bestDist = 0.6;
			for(%i = 0; %i < %count; %i++)
			{
				%str = %set.str[%i, 0];
				%type = %set.str[%i, 1];
				if (%type.aeAmmo $= "ALL")
					continue;

				%dist = strJaroDistance(%uiName, %str);
				if (%dist >= %bestDist) {
					%bestDist = %dist;
					%ammoType = %type;
				}
			}
		}
		else
			%ammoType = $AEStringCache[%uiName];

		if(!isObject(%ammoType))
		{
			messageClient(%cl, '', "\c2That ammo type could not be found");
			return;
		}

		$AEStringCache[%uiName] = %ammoType;
	}

	if(!isObject(%ammoType))
		return;

	if(%ammoType.aeAmmo $= "ALL")
	{
		messageClient(%cl, '', "\c2This type of ammo cannot be dropped");
		return;
	}

	%uiName = strreplace(%ammoType.uiName, "A: ", "");

	if(%pl.AEReserve[%ammoType] < %amt)
	{
		%amt = %pl.AEReserve[%ammoType];
		messageClient(%cl, '', '\c2You do not have enough %1 ammo. You only have %2', %uiName, %amt);
		return;
	}

	%itm = new Item()
	{
		dataBlock = %ammoType;
		position = %pl.getHackPosition();
		canPickup = true;
		static = false;
		minigame = getMinigameFromObject(%pl);
		bl_id = %cl.getBLID();
	};

	%vel = vectorAdd(vectorScale(%pl.getEyeVector(), 10), "0 0 2");

	%itm.setCollisionTimeout(%pl);
	%itm.setVelocity(%vel);
	%itm.schedulePop();
	%itm.aeAmmo = %amt;
	%itm.setShapeName(%uiName SPC "(" @ %amt @ ")");
	%itm.setShapeNameDistance(15);

	MissionCleanup.add(%itm);

	%pl.AEReserve[%ammoType] -= %amt;
	%pl.AENotifyAmmo(1);

	messageClient(%cl, '', '\c2You dropped %1 "%2" ammo', %amt, %uiName);
}

package aeAmmo
{
	function serverCmdLight(%cl)
	{
		if(isObject(%pl = %cl.player) && isObject(%img = %pl.getMountedImage(0)) && %img.item.AEBase)
		{
			if(%pl.aeAmmoCheck() < 2 && %pl.AEReserveCheck() > 0)
			{
				if(%pl.getImageState(0) $= "Ready" || %pl.getImageState(0) $= "Smoke" || %pl.getImageState(0) $= "Activate")
					%pl.setImageAmmo(0,0);
				else if(%pl.getImageState(0) $= "Empty" || %pl.getImageState(0) $= "Dryfire")
				{
					%pl.setImageAmmo(0,1);
					%pl.setImageLoaded(0,1);
				}

				return;
			}
		}

		Parent::serverCmdLight(%cl);
	}

	function Armor::onAdd(%db, %pl)
	{
		Parent::onAdd(%db, %pl);

		if(!isObject(aeAmmoSet))
			AEMakeAmmo();

		if(isObject(%pl) && %pl.getClassName() !$= "AIPlayer") // TODO!!: let AI players spawn with ammo - this is temporary to fix mag drops causing ammo to spawn on the player
		{
			for(%i = 0; %i < aeAmmoSet.getCount(); %i++)
			{
				%type = aeAmmoSet.getObject(%i);

				if(%pl.AEReserve[%type] $= "" && %type.aeAmmo !$= "ALL")
				{
					if($Pref::AEBase::FillReserveOnSpawn == 0)
						%pl.AEReserve[%type] = 0;
					else if($Pref::AEBase::FillReserveOnSpawn == 1)
						%pl.AEReserve[%type] = %type.AERefill;
					else if($Pref::AEBase::FillReserveOnSpawn == 2)
						%pl.AEReserve[%type] = %type.AEMax;
				}
			}
		}
	}

	function serverCmdDropTool(%cl, %slot)
	{
		if(isObject(%pl = %cl.player) && isObject(%pl.tool[%slot]))
		{
			%itm = %pl.tool[%slot].getid();
			
			if(%pl.aeAmmo[%slot, ""] !$= "")
			{
				$weaponAmmoTemp[%itm] = %pl.aeAmmo[%slot, ""];
				%pl.aeAmmo[%slot, ""] = "";
			}

			for(%i = 0; %i < getWordCount(%itm.AEAmmoTypes); %i++)
			{
				%type = getWord(%itm.AEAmmoTypes, %i);
				if(%pl.AEAmmo[%slot, %type] !$= "")
				{
					$weaponAmmoTemp[%itm, %type] = %pl.AEAmmo[%slot, %type];
					%pl.AEAmmo[%slot, %type] = "";
				}
			}
		}

		Parent::serverCmdDropTool(%cl, %slot);
	}
	
	function ItemData::onAdd(%this, %obj)
	{
		Parent::onAdd(%this, %obj);

		%uiName = strreplace(%this.uiName, "A: ", "");
		%amt = %this.AERefill;
		
		if(%this.AEIsAmmo)
		{
			if($Pref::AEBase::ammoitemspin)
				%obj.rotate = true;
			
			%obj.setShapeNameDistance(15);

			if(%this.AEAmmo !$= "ALL")
				%obj.setShapeName(%uiName SPC "(" @ %amt @ ")");    
			else
				%obj.setShapeName(%uiName SPC "(ALL)");    
		}

		if($weaponAmmoTemp[%this] !$= "")
		{
			%obj.aeAmmo = $weaponAmmoTemp[%this];
			$weaponAmmoTemp[%this] = "";
		}
		else if(!%this.AEIsAmmo && %this.aeAmmo > 0)
			%obj.aeAmmo = %this.aeAmmo;
		else if(%this.AERefill > 0)
			%obj.aeAmmo = %this.AERefill;

		for(%i = 0; %i < getWordCount(%this.AEAmmoTypes); %i++)
		{
			%type = getWord(%this.AEAmmoTypes, %i);
			if($weaponAmmoTemp[%this, %type] !$= "")
			{
				%obj.aeAmmo[%type] = $weaponAmmoTemp[%this, %type];
				$weaponAmmoTemp[%this, %type] = "";
			}
			else if(!%this.AEIsAmmo && %this.aeAmmo[%type] > 0)
				%obj.aeAmmo[%type] = %this.aeAmmo[%type];
			else if(%this.AERefill > 0)
				%obj.aeAmmo[%type] = %this.AERefill[%type];
		}

		%obj.types = %this.AEAmmoTypes;
	}

	function Player::Pickup(%pl, %item)
	{
		%db = %item.getDatablock();
		if(%item.canPickup)
		{
			if(%db.AEIsAmmo)
			{
				if(%db.aeAmmo $= "ALL")
				{
					%res = false;

					for(%i = 0; %i < aeAmmoSet.getCount(); %i++)
					{
						%type = aeAmmoSet.getObject(%i);
						if(%type.AEAmmo !$= "ALL" && %pl.AEReserve[%type] < %type.AEMax)
						{
							%pl.AEReserve[%type] = %type.AEMax;
							%res = true;
						}
					}

					if(%res)
					{
						%pl.AENotifyAmmo(1);

						if(isObject(%item.spawnBrick) && %item.static)
							%item.respawn();
						else
							%item.schedule(0, delete);
					}
				}
				else
				{
					%amt = %db.AERefill;
					if(%item.AEAmmo > 0)
						%amt = %item.aeAmmo;

					%old = %amt;

					if(%pl.AEReserve[%db] + %amt <= %db.AEMax)
					{
						%pl.AEReserve[%db] += %amt;
						%pl.AENotifyAmmo(%amt, %db);
						%amt = 0;
					}
					else
					{
						%final = %db.AEMax - %pl.AEReserve[%db];
						%pl.AEReserve[%db] += %final;
						%pl.AENotifyAmmo(%final, %db);
						%amt -= %final;
					}

					%item.aeAmmo = %amt;

					%str = %item.aeAmmo;
					if(%item.static)
						%str = %old;

					%item.setShapeName(strreplace(%db.uiName, "A: ", "") SPC "(" @ %str @ ")");

					if(%old > %amt)
					{
						if(isObject(%item.spawnBrick) && %item.static)
							%item.respawn();
						else if(%amt <= 0)
							%item.schedule(0, delete);
					}
				}
				return true;
			}
		}

		%ammo = %item.aeAmmo;
		%types = %item.types;
		for(%i = 0; %i < getWordCount(%types); %i++)
		{
			%type = getWord(%types, %i);
			$ammoTemp[%type] = %item.aeAmmo[%type];
		}

		%p = Parent::Pickup(%pl, %item);

		%db2 = %pl.getDatablock();

		if(%db.AEBase && !%db.AEIsAmmo)
		{
			if(%ammo !$= "")
			{
				for(%i = 0; %i < %db2.maxTools; %i++)
				{
					for(%w = 0; %w < getWordCount(%types); %w++)
					{
						%type = getWord(%types, %w);
						if(isObject(%pl.tool[%i].aeAmmo[%type]) && %pl.aeAmmo[%i, %type] $= "" && $ammoTemp[%type] !$= "")
						{
							%pl.aeAmmo[%i, %type] = $ammoTemp[%type];
							$ammoTemp[%type] = "";
						}
					}

					if(NameToID(%pl.tool[%i].AEType) == NameToID(%db.AEType) && %pl.aeAmmo[%i, ""] $= "")
					{
						%pl.aeAmmo[%i, ""] = %ammo;
						break;
					}
				}
			}
		}

		return %p;
	}

	function Armor::onCollision(%db,%pl,%item,%a,%b,%c,%d,%e,%f)
	{
		%db2 = %item.getDatablock();
		if($Pref::AEBase::ReserveAmmo)
		{
			if(%item.aeAmmo !$= "" && %item.canPickup && %pl.getDamagePercent() < 1.0 && minigameCanUse(%pl, %item) && !%pl.isBody && !%pl.isCorpse)
			{
				if(!%db2.AEIsAmmo)
				{
					for(%i = 0; %i < %db.maxTools; %i++)
					{
						if(%pl.tool[%i] == %db2.getID() && %pl.tool[%i].AEType.getID() == %db2.AEType.getID())
						{
							if(%item.aeAmmo > 0)
							{
								%res = false;
								for(%w = 0; %w <= getWordCount(%item.types); %w++)
								{
									%aidx = "";

									if(%w != getWordCount(%item.types))
										%aidx = getWord(%item.types, %w);

									%type = %db2.AEType[%aidx];

									if(%db2.AENoReserve[%aidx])
										continue;

									if(%pl.AEReserve[%type] + %item.aeAmmo[%aidx] <= %type.AEMax)
									{
										%res = true;
										%pl.AEReserve[%type] += %item.aeAmmo[%aidx];
										%pl.AENotifyAmmo(%item.aeAmmo[%aidx], %type);
										if(!isObject(%item.spawnBrick) && !%item.static)
											%item.aeAmmo[%aidx] = 0;
									}
									else if(%pl.AEReserve[%type] < %type.AEMax)
									{
										%res = true;
										%amt = %type.AEMax - %pl.AEReserve[%type];
										%pl.AEReserve[%type] += %amt;

										%pl.AENotifyAmmo(%amt, %type);
										if(!isObject(%item.spawnBrick) && !%item.static)
											%item.aeAmmo[%aidx] -= %amt;
									}
								}

								if(isObject(%item.spawnBrick) && %item.static && %res)
									%item.respawn();

								return;
							}
						}
					}
				}
				else
				{
					%pl.Pickup(%item);
					return;
				}
			}
		}

		return Parent::onCollision(%db,%pl,%item,%a,%b,%c,%d,%e,%f);
	}
};
activatePackage(aeAmmo);

function Player::AENotifyAmmo(%pl, %amt, %type)
{
	if(%amt <= 0)
		return;

	if($Pref::AEBase::ammosound && getSimTime() - %pl.lastPickupSound > 100)
	{
		serverPlay3D(AEAmmoPickupSound, %pl.getPosition());
		%pl.lastPickupSound = getSimTime();
	}

	if(isObject(%img = %pl.getMountedImage(0)) && %img.item.aebase)
		%pl.baadDisplayAmmo(%img);

	if(!isObject(%cl = %pl.Client) || !isObject(%type) || %type.AEAmmo $= "ALL")
		return;

	if($Pref::AEBase::ammomessage)
		messageClient(%cl, '', "<font:arial bold:14><color:f8fc03>+" @ %amt SPC %type.aeAmmo @ " ammo");
}

function Player::AEDumpAmmo(%pl)
{
	if(!$Pref::AEBase::AmmoDeathDrop)
		return;

	for(%i = 0; %i < aeAmmoSet.getCount(); %i++)
	{
		%type = aeAmmoSet.getObject(%i);

		if((%amt = %pl.AEReserve[%type]) !$= "" && %type.aeAmmo !$= "ALL")
		{
			if(%amt <= 0)
				continue;

			%itm = new Item()
			{
				dataBlock = %type;
				position = %pl.getHackPosition();
				canPickup = true;
				static = false;
				minigame = getMinigameFromObject(%pl);
				bl_id = (isObject(%cl = %pl.Client) ? %cl.getBLID() : -1);
			};

			%itm.setCollisionTimeout(%pl);
			%itm.setVelocity(getRandom(-6, 6) SPC getRandom(-6, 6) SPC getRandom(-6, 6));
			%itm.schedulePop();
			%itm.aeAmmo = %amt;

			MissionCleanup.add(%itm);

			%pl.AEReserve[%type] = 0;
		}
	}
}

package aeAmmoPersist
{
	function Player::onInvShiftSwap(%pl, %pre, %predb, %post, %postdb)
	{
		%back = Parent::onInvShiftSwap(%pl, %pre, %predb, %post, %postdb);

		if(%back)
		{
			%preAmmo = %pl.aeAmmo[%pre, ""];
			%postAmmo = %pl.aeAmmo[%post, ""];
			if(%postAmmo !$= "") %pl.aeAmmo[%pre, ""] = %postAmmo;
			if(%preAmmo !$= "") %pl.aeAmmo[%post, ""] = %preAmmo;

			for(%i = 0; %i < getWordCount(%predb.AEAmmoTypes); %i++)
			{
				%type = getWord(%itm.AEAmmoTypes, %i);
				%preAmmo[%type] = %pl.aeAmmo[%pre, %type];
			}

			for(%i = 0; %i < getWordCount(%postdb.AEAmmoTypes); %i++)
			{
				%type = getWord(%itm.AEAmmoTypes, %i);
				%postAmmo[%type] = %pl.aeAmmo[%post, %type];
			}
			// This is fucking retarded and I should probably look for a better way of doing it
			for(%i = 0; %i < getWordCount(%predb.AEAmmoTypes); %i++)
			{
				%type = getWord(%itm.AEAmmoTypes, %i);
				if(%preAmmo[%type] !$= "") %pl.aeAmmo[%post, %type] = %preAmmo[%type];
			}

			for(%i = 0; %i < getWordCount(%postdb.AEAmmoTypes); %i++)
			{
				%type = getWord(%itm.AEAmmoTypes, %i);
				if(%postAmmo[%type] !$= "") %pl.aeAmmo[%pre, %type] = %postAmmo[%type];
			}
		}

		return %back;
	}

	function Armor::onDisabled(%db, %pl, %state)
	{
		if(isObject(%pl))
			%pl.AEDumpAmmo();

		return Parent::onDisabled(%db, %pl, %state);
	}

	function Armor::onRemove(%db, %pl, %x, %y)
	{
		if(isObject(%pl))
			%pl.AEDumpAmmo();

		return Parent::onRemove(%db, %pl, %x, %y);
	}
};
activatePackage(aeAmmoPersist);
