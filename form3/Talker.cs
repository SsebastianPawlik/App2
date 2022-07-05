using System;
using System.Windows.Forms;

namespace form3
{
	internal class Talker
	{
		
			public static int BlahBlah(string thingToSay, int numberOfTime)
			{
				string finalString = "";
				for (int count = 1; count <= numberOfTime; count++)
				{
					finalString = finalString + thingToSay + "\n";
				}
				MessageBox.Show(finalString);
				return finalString.Length;
			}
		}
	}

