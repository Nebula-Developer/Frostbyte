# (Feature Title) EG: RenderStack

## Summary

(One paragraph explanation of the feature.)
EG:
RenderStack is a class that will render multiple displays at a time, with an order and either framerate or called rendering.

## Usage

(How to use the feature.)
EG:
```cs
RenderStack stack = new RenderStack();
Display display = new Display();
stack.Add(display);
// Render the stack with a called render
stack.Render();
// Render the stack with a framerate
stack.Config.FPS = 60;
stack.Config.UseIdealRenderFrequency = true;
stack.StartRenderLoop();
```
