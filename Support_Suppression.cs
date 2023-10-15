function Projectile::AEFlybyLoop(%proj, %super)
{
	cancel(%proj.whizzloop);

	if(!isObject(%proj) || !$Pref::AEBase::suppression)
		return;
	
	if(%proj.suppressed $= "")
	{
		// avoid suppressing on the first tick to avoid double suppression with static hitscans
		%proj.suppressed = true;
	}
	else
	{
		%src = %proj.sourceObject;

		if(isObject(%src) && (%src.IsA("Player") || %src.IsA("AIPlayer")))
			%proj.suppressed[%src] = true;
		
		AESuppressArea(%proj.getPosition(), vectorNormalize(%proj.getVelocity()), %proj, %proj.sourceImage);
	}

	%proj.whizzloop = %proj.schedule(34, AEFlybyLoop, %super);
}

function AETrailedProjectile::onStaticHitscanStep(%db, %src, %start, %end, %dir, %shape, %img)
{
	if(!%img.sonicWhizz || !$Pref::AEBase::suppression)
		return;
	
	if(isObject(%src) && (%src.IsA("Player") || %src.IsA("AIPlayer")))
		%shape.suppressed[%src] = true;
	
	//AESuppressArea(%start, %dir, %shape, %img);

	%dist = vectorDist(%start, %end);
	%int = 2;
	%cts = mFloor(%dist / %int);

	for(%i = 0; %i < %cts; %i++)
	{
		%pos = vectorAdd(%start, vectorScale(%dir, %int * %i));

		AESuppressArea(%pos, %dir, %shape, %img);
		//talk("d " @ vectorDist(%start, %pos));
	}

	//talk(vectorDist(%start, %end));
}

function AESuppressArea(%pos, %dir, %shape, %img)
{
	%super = %img.whizzSupersonic;

	if(%super == 0)
		%sfx = AESubsonicWhizz @ getRandom(1, 4) @ Sound;
	else if(%super == 1)
		%sfx = AESupersonicCrack @ getRandom(1, 4) @ Sound;
	else if(%super == 2)
		%sfx = AESupersonicBigCrack @ getRandom(1, 4) @ Sound;
	
	%angle = 1 - (%img.whizzAngle / 90);
	%chance = mClampF(%img.whizzChance / 100, 0, 1);
	%through = %img.whizzThrough;

	for(%i = 0; %i < ClientGroup.getCount(); %i++)
	{
		%cc = ClientGroup.getObject(%i);

		%obj = %cc.getControlObject();

		if(!isObject(%obj) || %shape.suppressed[%obj])
			continue;
		
		%eye = %obj.getEyePoint();

		%dist = vectorDist(%pos, %eye);
		%dot = vectorDot(%dir, vectorNormalize(vectorSub(%pos, %eye)));

		if(%dist < %img.whizzDistance && %dot <= %angle && getRandom() <= %chance)
		{
			if(%through || !isObject(containerRayCast(%pos, %eye, $TypeMasks::fxBrickObjectType | $trapStaticTypemask)))
			{
				%shape.suppressed[%obj] = true;
				%cc.play3D(%sfx, %pos);

				%p = new Projectile()
				{
					dataBlock = R_ShotgunRecoilProjectile;
					initialPosition = %eye;
				};

				%p.setScale("0.1 0.1 0.1");

				MissionCleanup.add(%p);

				%p.explode();
			}
		}
	}
}

function AEProjectile::onStaticHitscanStep(%db, %src, %start, %end, %dir, %shape, %img)
{
	AETrailedProjectile::onStaticHitscanStep(%db, %src, %start, %end, %dir, %shape, %img);
}

package AESuppressionFX
{
	function Projectile::onAdd(%proj)
	{
		Parent::onAdd(%proj);

		if(!isObject(%proj))
			return;
		
		if(%proj.sonicWhizz)
			%proj.AEFlybyLoop(%proj.whizzSupersonic);
	}
};
activatePackage(AESuppressionFX);