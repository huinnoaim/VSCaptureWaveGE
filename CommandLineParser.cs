/*
 * This file is part of VitalSignsCaptureWave v1.011.
 * Copyright (C) 2015-22 John George K., xeonfusion@users.sourceforge.net

    VitalSignsCapture is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    VitalSignsCapture is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with VitalSignsCapture.  If not, see <http://www.gnu.org/licenses/>.*/

namespace VSCaptureWave
{
  public class CommandLineParser
    {
        public CommandLineParser()
        {
            Arguments = new Dictionary<string, string[]>();
        }

        public IDictionary<string, string[]> Arguments { get; private set; }

        public void Parse(string[] args)
        {
            string currentName = "";
            var values = new List<string>();
            foreach (string arg in args)
            {
                if (arg.StartsWith("-", StringComparison.InvariantCulture))
                {
                    if (currentName != "" && values.Count != 0)
                        Arguments[currentName] = values.ToArray();

                    else
                    {
                        values.Add("");
                        Arguments[currentName] = values.ToArray();
                    }
                    values.Clear();
                    currentName = arg.Substring(1);
                }
                else if (currentName == "")
                    Arguments[arg] = new string[0];
                else
                    values.Add(arg);
            }

            if (currentName != "")
                Arguments[currentName] = values.ToArray();
        }

        public bool Contains(string name)
        {
            return Arguments.ContainsKey(name);
        }
    }

}


