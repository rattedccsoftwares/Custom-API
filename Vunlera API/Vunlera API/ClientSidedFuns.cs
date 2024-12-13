using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.functionESC;

namespace API
{
    internal class ClientSidedFuns
    {

        public static string Fire = @"
local player = game.Players.LocalPlayer
local character = player.Character or player.CharacterAdded:Wait()
local torso = character:WaitForChild(""Torso"") or character:WaitForChild(""UpperTorso"")

local fire = Instance.new(""Fire"")
fire.Size = 10
fire.Heat = 5
fire.Parent = torso

     
     ";

        public static string Smoke = @"
local player = game.Players.LocalPlayer
local character = player.Character or player.CharacterAdded:Wait()
local torso = character:WaitForChild(""Torso"") or character:WaitForChild(""UpperTorso"")

local smoke = Instance.new(""Smoke"")
smoke.Size = 10
smoke.Opacity = 0.5
smoke.Color = Color3.new(0.5, 0.5, 0.5)
smoke.Parent = torso



";
        public static string Sparkles = @"

local player = game.Players.LocalPlayer
local character = player.Character or player.CharacterAdded:Wait()
local torso = character:WaitForChild(""Torso"") or character:WaitForChild(""UpperTorso"")

local sparkles = Instance.new(""Sparkles"")
sparkles.Size = 10
sparkles.Color = Color3.new(1, 1, 1) -- White color
sparkles.Parent = torso
";
        public static void AddFire()
        {
            ESC.ESCexec(Fire);
        }
        public static void AddSmoke()
        {
            ESC.ESCexec(Smoke);
        }
        public static void AddSparkles()
        {
            ESC.ESCexec(Sparkles);
        }

    }
}
