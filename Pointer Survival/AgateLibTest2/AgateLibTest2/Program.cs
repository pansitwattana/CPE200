﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgateLib;
using AgateLib.DisplayLib;
using AgateLib.Geometry;

namespace AgateLibTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AgateSetup setup = new AgateSetup(args))
            {
                // initialize AgateLib.
                setup.InitializeAll();
                // if something bad happened, bail out.
                if (setup.WasCanceled)
                    return;
                // Create a window with resolution 640x480 and title "Hello World"
                DisplayWindow wind = DisplayWindow.CreateWindowed("Hello World", 640, 480);
                // Run the program while the window is open.
                while (Display.CurrentWindow.IsClosed == false)
                {
                    // Display.BeginFrame must be called at the start of every frame,
                    // before rendering takes place.
                    Display.BeginFrame();
                    // Clears the display to a nice color.
                    Display.Clear(Color.DarkGreen);
                    // End frame must be called after all drawing is finished.
                    Display.EndFrame();

                    // KeepAlive processes events.
                    Core.KeepAlive();
                }

            }
        }
    }
}
