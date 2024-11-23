using Godot;
using System;

public partial class MouseMovableCamera : Camera2D
{
    [Export] private float ZoomSpeed = 0.1f; // Speed of zooming
    [Export] private float PanSpeed = 200f; // Speed of panning
    [Export] private float MinZoom = 0.5f;  // Minimum zoom level
    [Export] private float MaxZoom = 4f;    // Maximum zoom level

    private Vector2 _lastMousePosition;
    private bool _isPanning = false;


    public override void _Ready()
    {
        
    }

    public override void _Process(double delta)
    {
		if (Input.IsMouseButtonPressed(MouseButton.Middle))
        {
            // Start panning if the middle mouse button is pressed
            if (!_isPanning)
            {
                _lastMousePosition = GetViewport().GetMousePosition();
                _isPanning = true;
            }

            Vector2 currentMousePosition = GetViewport().GetMousePosition();
            Vector2 mouseDelta = _lastMousePosition - currentMousePosition;

            // Move the camera by the mouse delta
            Position += mouseDelta * PanSpeed * (float)delta;
            _lastMousePosition = currentMousePosition;
        }
        else
        {
            _isPanning = false;
        }

    }

}
