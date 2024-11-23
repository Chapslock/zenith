using Godot;
using System;

public partial class WorldGenerator : TileMapLayer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		TestGeneration3();
	}


    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}

	private void TestGeneration3() {
		GenerateTileMap(1000, 1000);
    }

    private void GenerateTileMap(int width, int height)
    {
        for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {
				SetCell(new Vector2I(x, y), 0, new Vector2I(y%3,5));
			}
		}
    }
}
