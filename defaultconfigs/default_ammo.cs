private AmmoDef Example_Ammo => new AmmoDef
{
    AmmoMagazine = "Energy",
    BaseDamage = 2795,
    HardPointUsable = true,
    NoGridOrArmorScaling = true, 
    Trajectory = new TrajectoryDef
    {
		MaxLifeTime = 980,
		MaxTrajectory = 6397,
		DesiredSpeed = 5000,
    },
    AmmoGraphics = new GraphicDef
    {
	VisualProbability = 1f,
	Lines = new LineDef
	{
	   Tracer = new TracerBaseDef
	   {
	       Enable = true,
	       Length = 10f,
	       Width = 0.1f,
	       Color = Color(red: 159, green: 184, blue: 129, alpha: 1f),
	       Textures = new[] {"ProjectileTrailLine",},
	   },
	},
    },
};