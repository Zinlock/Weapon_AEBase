// Repurposed code from Oxy's pretty much scrapped BKT2 pack

function AEMakeAmmo()
{
	if(isObject(AEAmmoSet))
		AEAmmoSet.delete();
	
	new SimSet(AEAmmoSet);

	%evstr = "list ALL 0";
	%cts = 0;

	for(%i = 0; %i < dataBlockGroup.getCount(); %i++)
	{
		%db = dataBlockGroup.getObject(%i);
		if(%db.AEAmmo !$= "" && %db.AEMax > 0 && %db.AERefill > 0)
		{
			AEAmmoSet.add(%db);
			%evstr = %evstr SPC strReplace(%db.AEAmmo, " ", "_") SPC %cts+1;
			AEAmmoSet.ammo[%cts + 1] = %db;
			%db.AEAmmoIdx = %cts + 1;

			%cts++;
		}
	}

	registerOutputEvent("Player", "supplyAEAmmo", %evstr @ "\tint 1 4096 20\tbool");
	registerOutputEvent("Player", "refillAEAmmo", %evstr @ "\tbool");
	registerOutputEvent("Player", "resetAEAmmo", %evstr @ "\tbool");
	registerOutputEvent("Player", "setAEAmmo", %evstr @ "\tint 0 4096 20\tbool\tbool");

	AEAmmoSet.add(AE_AmmoItem);
	AEAmmoSet.ammo[0] = AE_AmmoItem;
}

$OutputDescription_["Player", "supplyAEAmmo"] = "[type] [amount] [tell]" NL
																							 	"Gives this player AEBase reserve ammo." NL
																								"type: Ammo type to give" NL
																								"amount: Amount of ammo to give" NL
																								"tell: Lists gained ammo count";

$OutputDescription_["Player", "refillAEAmmo"] = "[type] [tell]" NL
																							 	"Entirely refills this player's AEBase reserve ammo." NL
																								"type: Ammo type to refill" NL
																								"tell: Lists gained ammo count";

$OutputDescription_["Player", "resetAEAmmo"] = "[type] [tell]" NL
																							 "Resets this player's AEBase reserve ammo to its default value." NL
																							 "type: Ammo type to set" NL
																							 "tell: Lists gained ammo count";

$OutputDescription_["Player", "setAEAmmo"] = "[type] [amount] [tell] [force]" NL
																						 "Sets this player's AEBase reserve ammo." NL
																						 "type: Ammo type to set" NL
																						 "amount: Amount of ammo to set to" NL
																						 "tell: Lists gained ammo count" NL
																						 "force: Bypass the default reserve limit";

function Player::supplyAEAmmo(%pl, %idx, %amt, %note)
{
	if(%idx == 0)
	{
		for(%i = 0; %i < AEAmmoSet.getCount(); %i++)
		{
			%ammo = AEAmmoSet.getObject(%i);
			if(%ammo.AEAmmo !$= "ALL")
				%pl.supplyAEAmmo(%ammo.AEAmmoIdx, %amt, %note);
		}

		return;
	}

	%db = AEAmmoSet.ammo[%idx];
	if(%pl.AEReserve[%db] + %amt <= %db.AEMax)
	{
		%pl.AEReserve[%db] += %amt;
		if(%note) %pl.AENotifyAmmo(%amt, %db);
		%amt = 0;
	}
	else
	{
		%final = %db.AEMax - %pl.AEReserve[%db];
		%pl.AEReserve[%db] += %final;
		if(%note) %pl.AENotifyAmmo(%final, %db);
		%amt -= %final;
	}
}

function Player::refillAEAmmo(%pl, %idx, %note)
{
	if(%idx == 0)
	{
		for(%i = 0; %i < AEAmmoSet.getCount(); %i++)
		{
			%ammo = AEAmmoSet.getObject(%i);
			if(%ammo.AEAmmo !$= "ALL")
				%pl.refillAEAmmo(%ammo.AEAmmoIdx, %note);
		}

		return;
	}
	
	%db = AEAmmoSet.ammo[%idx];
	%last = %pl.AEReserve[%db];
	%pl.AEReserve[%db] = %db.AEMax;

	if(%note) %pl.AENotifyAmmo(%db.AEMax - %last, %db);
}

function Player::resetAEAmmo(%pl, %idx, %note)
{
	if(%idx == 0)
	{
		for(%i = 0; %i < AEAmmoSet.getCount(); %i++)
		{
			%ammo = AEAmmoSet.getObject(%i);
			if(%ammo.AEAmmo !$= "ALL")
				%pl.resetAEAmmo(%ammo.AEAmmoIdx, %note);
		}

		return;
	}
	
	%db = AEAmmoSet.ammo[%idx];
	%last = %pl.AEReserve[%db];

	if($Pref::AEBase::FillReserveOnSpawn == 0)
		%pl.AEReserve[%db] = 0;
	else if($Pref::AEBase::FillReserveOnSpawn == 1)
		%pl.AEReserve[%db] = %db.AERefill;
	else if($Pref::AEBase::FillReserveOnSpawn == 2)
		%pl.AEReserve[%db] = %db.AEMax;

	if(%note) %pl.AENotifyAmmo(%db.AEMax - %last, %db);
}

function Player::setAEAmmo(%pl, %idx, %amt, %note, %force)
{
	if(%idx == 0)
	{
		for(%i = 0; %i < AEAmmoSet.getCount(); %i++)
		{
			%ammo = AEAmmoSet.getObject(%i);
			if(%ammo.AEAmmo !$= "ALL")
				%pl.setAEAmmo(%ammo.AEAmmoIdx, %amt, %note, %force);
		}

		return;
	}

	%db = AEAmmoSet.ammo[%idx];

	if(%amt < 0)
		%amt = 0;
	else if(!%force && %amt > %db.AEMax)
		%amt = %db.AEMax;

	%last = %pl.AEReserve[%db];
	%pl.AEReserve[%db] = %amt;

	if(%note && %pl.AEReserve[%db] - %last > 0) %pl.AENotifyAmmo(%pl.AEReserve[%db] - %last, %db);
}

datablock ItemData(AE_AmmoItem : hammerItem)
{
	iconName = "";
	image = "";
	doColorShift = false;
	colorShiftColor = "1 1 1 1";

	shapeFile = "./ammo/cache.dts";
	uiName = "A: Ammo Supply";

	AEIsAmmo = true;
	AEAmmo = "ALL";
	iconName = "./ammo/Icon_Supply";
};

datablock ItemData(AE_DeathAmmoItem : AE_AmmoItem)
{
	//shapeFile = "./dts/ammo/death.dts";
	uiName = "";

	AEIsAmmo = true;
	AEAmmo = "MULTI";
};

// Ammo Types and Pickups :D

datablock ItemData(AE_LightAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/light.dts";
	uiName = "A: Light Ammo";
	AEAmmo = "Light Ammo";
	AEMax = 210;
	AERefill = 30;
	iconName = "./ammo/Icon_Light";
};

datablock ItemData(AE_MediumAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/medium.dts";
	uiName = "A: Medium Ammo";
	AEAmmo = "Medium Ammo";
	AEMax = 300;
	AERefill = 60;
	iconName = "./ammo/Icon_Medium";
};

datablock ItemData(AE_HeavyAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/heavy.dts";
	uiName = "A: Heavy Ammo";
	AEAmmo = "Heavy Ammo";
	AEMax = 240;
	AERefill = 60;
	iconName = "./ammo/Icon_Heavy";
};

datablock ItemData(AE_ShotgunAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/shotgun.dts";
	uiName = "A: Shotgun Ammo";
	AEAmmo = "Shotgun Ammo";
	AEMax = 150;
	AERefill = 10;
	iconName = "./ammo/Icon_Shotgun";
};

datablock ItemData(AE_SpecialAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/special.dts";
	uiName = "A: Special Ammo";
	AEAmmo = "Special Ammo";
	AEMax = 12;
	AERefill = 2;
	iconName = "./ammo/Icon_Special";
};

schedule(0, 0, AEMakeAmmo);