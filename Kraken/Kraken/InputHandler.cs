using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Kraken
{
        //The current state of a key
    public enum InputState
    {
        None,
        Pressed,
        Held,
        LetGo
    }

    public class InputHandler
    {
        static KeyboardState oldState;
        static KeyboardState newState;

        public InputHandler()
        {
            
        }

        public void Update(GameTime gameTime)
        {
                //Set the old state using the previous new state
            oldState = newState;
                //Get the current state
            newState = Keyboard.GetState();
        }

        public static InputState GetState(Keys key)
        {
                //If the user just pressed the key
            if (newState.IsKeyDown(key) && !oldState.IsKeyDown(key))
                return InputState.Pressed;
                //If the user held the key
            else if (newState.IsKeyDown(key) && oldState.IsKeyDown(key))
                return InputState.Held;
                //If the user just let go of the key
            else if (!newState.IsKeyDown(key) && oldState.IsKeyDown(key))
                return InputState.LetGo;
                //No state detected
            return InputState.None;
        }
    }
}
