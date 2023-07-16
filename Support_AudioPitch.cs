function isBlocklandRebuilt() { return false; } // gets replaced if we are on rebuilt

if($Version !$= "21" && !isBlocklandRebuilt()) // doesn't work outside of v21
	return;
	
if($Server::Dedicated || isBlocklandRebuilt()) // this causes timescale issues on non dedi retail servers
	schedule(0, 0, activatePackage, AudioRandomPitch);

package AudioRandomPitch
{
	function GameConnection::Play3D(%cl, %sound, %pos)
	{
		%pitchDev = %sound.pitchRange;
		if(%pitchDev $= "") return Parent::Play3D(%cl, %sound, %pos);

		%maxPitch = 100 + %pitchDev;
		%minPitch = 100 - %pitchDev;

		%pitch = (getRandom(%minPitch, %maxPitch)) / 100;

		%cl.playPitched3D(%sound, %pos, %pitch);
	}

	function GameConnection::Play2D(%cl, %sound)
	{
		%pitchDev = %sound.pitchRange;
		if(%pitchDev $= "") return Parent::Play2D(%cl, %sound);

		%maxPitch = 100 + %pitchDev;
		%minPitch = 100 - %pitchDev;

		%pitch = (getRandom(%minPitch, %maxPitch)) / 100;

		%cl.playPitched2D(%sound, %pitch);
	}
};

if(isBlocklandRebuilt())
	return;

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