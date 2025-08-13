using Godot;
using System;

public partial class GBank : Node2D
{
	public static GBank Instance;
	public override void _Ready()
	{
		base._Ready();
		Instance = this;
	}
	[Export] public float G_aaa = 1f;
}
