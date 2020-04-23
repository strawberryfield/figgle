﻿#region License

// Copyright 2017 Drew Noakes
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System;

// ReSharper disable FunctionNeverReturns

namespace Figgle.Cmd
{
    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Write("Message: ");

                var message = Console.ReadLine();

                try
                {
                    Console.WriteLine(FiggleFonts.Lookup("standard").Render(message));
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine($"Exception: {e}");
                }
            }
        }
    }
}
