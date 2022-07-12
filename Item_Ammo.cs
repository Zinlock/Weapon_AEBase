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
	doColorShift = true;
	colorShiftColor = "0.471 0.471 0.471 1.000";

	shapeFile = "base/data/shapes/brickweapon.dts";
	//shapeFile = "./dts/ammo/cache.dts";
	uiName = "A: Ammo Supply";

	AEIsAmmo = true;
	AEAmmo = "ALL";
};

datablock ItemData(AE_DeathAmmoItem : AE_AmmoItem)
{
	//shapeFile = "./dts/ammo/death.dts";
	uiName = "";

	AEIsAmmo = true;
	AEAmmo = "MULTI";
};

datablock ItemData(AE_HeavyRAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/762mm.dts";
	uiName = "A: 7.62 Medium Rifle";
	AEAmmo = "7.62 Medium Rifle";
	AEMax = 270;
	AERefill = 60;
};

datablock ItemData(AE_DMRAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/762mm.dts";
	uiName = "A: 7.62 Marksman Rifle";
	AEAmmo = "7.62 Marksman Rifle";
	AEMax = 270;
	AERefill = 60;
};

datablock ItemData(AE_LMGAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/762mm.dts";
	uiName = "A: Light Machine Gun";
	AEAmmo = "L. Machine Gun";
	AEMax = 270;
	AERefill = 60;
};

datablock ItemData(AE_PDRAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/556mm.dts";
	uiName = "A: 5.7 Little Rifle";
	AEAmmo = "5.7 Little Rifle";
	AEMax = 270;
	AERefill = 60;
};

datablock ItemData(AE_LightRAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/556mm.dts";
	uiName = "A: 5.56 Medium Rifle";
	AEAmmo = "5.56 Medium Rifle";
	AEMax = 270;
	AERefill = 60;
};

datablock ItemData(AE_HeavySRAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/50cal.dts";
	uiName = "A: 50. Heavy Sniper";
	AEAmmo = ".50 Heavy Sniper";
	AEMax = 40;
	AERefill = 8;
};

datablock ItemData(AE_MediumSRAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/338lmag.dts";
	uiName = "A: .338 Sniper";
	AEAmmo = ".338 Sniper";
	AEMax = 64;
	AERefill = 12;
};

datablock ItemData(AE_LightPAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/9mm.dts";
	uiName = "A: 9mm Pistol";
	AEAmmo = "9mm Pistol";
	AEMax = 210;
	AERefill = 36;
};

datablock ItemData(AE_SuperLightPAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/22lr.dts";
	uiName = "A: .22 Long Rifle";
	AEAmmo = ".22 Long Rifle";
	AEMax = 320;
	AERefill = 68;
};

datablock ItemData(AE_MediumPAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/45acp.dts";
	uiName = "A: .45 Heavy Pistol";
	AEAmmo = ".45 Heavy Pistol";
	AEMax = 180;
	AERefill = 28;
};

datablock ItemData(AE_HeavyPAmmoItem : AE_AmmoItem)
{
	//shapeFile = "./ammo/magnum.dts";
	uiName = "A: .357 Magnum";
	AEAmmo = ".357 Magnum";
	AEMax = 120;
	AERefill = 12;
};

datablock ItemData(AE_HeavySAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/4ga.dts";
	uiName = "A: 4 Gauge Heavy S.";
	AEAmmo = "4 Gauge Shotgun";
	AEMax = 42;
	AERefill = 6;
};

datablock ItemData(AE_LightSAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/12gaugebox.dts";
	uiName = "A: 12 Gauge Shotgun";
	AEAmmo = "12 Gauge Shotgun";
	AEMax = 64;
	AERefill = 12;
};

datablock ItemData(AE_GrenadeLAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/40mm.dts";
	uiName = "A: 40mm Grenade";
	AEAmmo = "40mm Grenade";
	AEMax = 12;
	AERefill = 4;
};

datablock ItemData(AE_RocketLAmmoItem : AE_AmmoItem)
{
	shapeFile = "./ammo/rpg.dts";
	uiName = "A: Rocket L.";
	AEAmmo = "Rocket L.";
	AEMax = 6;
	AERefill = 2;
};

schedule(0, 0, AEMakeAmmo);