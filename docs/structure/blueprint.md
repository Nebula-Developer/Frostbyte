### This is an example documentation file for a feature. It should be used as a template for new features.

<br>

# [Docs](/docs/README.md) - RenderStack

## Summary

RenderStack is a class that will render multiple displays at a time, with an order and either framerate or called rendering.

## Usage

```cs
RenderStack stack = new RenderStack();
Display display = new Display();                // Display is a class that will layout elements to render, but does not render them itself

stack.Add(display);                             // Add a display to the stack
stack.Render();                                 // Render the stack with a called render

stack.Config.FPS = 60;                          // Set the render loop framerate
stack.Config.UseIdealRenderFrequency = true;    // Set the render loop to use the ideal render frequency
stack.StartRenderLoop();                        // Start the render loop
```
