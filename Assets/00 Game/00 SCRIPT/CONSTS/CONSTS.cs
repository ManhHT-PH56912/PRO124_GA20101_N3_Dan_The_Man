using System;
using UnityEngine;

namespace Consts
{
    public static class Scene
    {
        public const string AUTHENTICATION = "authentication";
        public const string MAIN_MENU = "MainMenu";

        public const string SHOP_SCREEN = "Shop";
        public const string MAP1 = "Map";
    }

    public static class Tags
    {
        public static string PLAYER_TAG = "Player";
        public static string ENEMY_TAGS = "Enemy";
        public static string TRAP_TAG = "Trap";
        public static string MEXT_lEVEL_TAG = "NextLevel";
        public static string CHECKPOINT_TAG = "";
    }

    public static class Layers
    {
        public static LayerMask ground = LayerMask.GetMask("Ground");
    }
}