private AmmoDef Example_Ammo => new AmmoDef
{
    AmmoMagazine = "Energy",
    BaseDamage = 2795,
    HardPointUsable = true,
    NoGridOrArmorScaling = true, 
    Trajectory = new TrajectoryDef
    {
		MaxLifeTime = 3547,
		MaxTrajectory = 4339,
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
	       Color = Color(red: 255, green: 74, blue: 129, alpha: 1f),
	       Textures = new[] {"ProjectileTrailLine",},
	   },
	},
    },
};