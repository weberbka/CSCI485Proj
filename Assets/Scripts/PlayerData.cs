using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerData {
	public struct Weapon
	{
		public string name;
		public int typeDice;
		public int numDice;
	}
	public struct Enemy
	{
		public string name;
		public int typeDice;
		public int numDice;
	}
	public static Weapon weapon = new Weapon{name = "Fists", typeDice = 6, numDice = 1};
	public static Enemy currentBattle = new Enemy{name = "Zombie", typeDice = 6, numDice = 1};
}
