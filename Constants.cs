using System.Collections.Generic;
using Unit06.Game.Casting;


namespace Unit06
{
    public class Constants
    {
        // ----------------------------------------------------------------------------------------- 
        // GENERAL GAME CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // GAME
        public static string GAME_NAME = "Soup R Mario Lost in the Bitlands";
        public static int FRAME_RATE = 60;

        // SCREEN
        public static int SCREEN_WIDTH = 1040;
        public static int SCREEN_HEIGHT = 680;
        public static int CENTER_X = SCREEN_WIDTH / 2;
        public static int CENTER_Y = SCREEN_HEIGHT / 2;

        // FIELD
        public static int FIELD_TOP = 60;
        public static int FIELD_BOTTOM = SCREEN_HEIGHT;
        public static int FIELD_LEFT = 0;
        public static int FIELD_RIGHT = SCREEN_WIDTH;

        // FONT
        public static string FONT_FILE = "Assets/Fonts/zorque.otf";
        public static int FONT_SIZE = 32;

        // SOUND
        public static string BOUNCE_SOUND = "Assets/Sounds/smw_jump.wav";
        public static string WELCOME_SOUND = "Assets/Sounds/start.wav";
        public static string OVER_SOUND = "Assets/Sounds/over.wav";

        //MUSIC
        public static string MUSIC_TRACK_1 = "Assets/Sounds/16 Athletic.mp3";

        // TEXT
        public static int ALIGN_LEFT = 0;
        public static int ALIGN_CENTER = 1;
        public static int ALIGN_RIGHT = 2;


        // COLORS
        public static Color BLACK = new Color(0, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color PURPLE = new Color(255, 0, 255);
        public static Color BLUE = new Color(100, 150, 225);

        // KEYS
        public static string LEFT = "left";
        public static string RIGHT = "right";
        public static string UP = "up";
        public static string DOWN = "down";
        public static string SPACE = "space";
        public static string ENTER = "enter";
        public static string PAUSE = "p";
        public static string OZ = "o";


        // SCENES
        public static string NEW_GAME = "new_game";
        public static string TRY_AGAIN = "try_again";
        public static string NEXT_LEVEL = "next_level";
        public static string IN_PLAY = "in_play";
        public static string GAME_OVER = "game_over";

        // LEVELS
        public static string LEVEL_FILE = "Assets/Data/level-{0:000}.txt";
        public static int BASE_LEVELS = 5;

        // ----------------------------------------------------------------------------------------- 
        // SCRIPTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // PHASES
        public static string INITIALIZE = "initialize";
        public static string LOAD = "load";
        public static string INPUT = "input";
        public static string UPDATE = "update";
        public static string OUTPUT = "output";
        public static string UNLOAD = "unload";
        public static string RELEASE = "release";

        // ----------------------------------------------------------------------------------------- 
        // CASTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // STATS
        public static string STATS_GROUP = "stats";
        public static int DEFAULT_LIVES = 30;
        public static int MAXIMUM_LIVES = 5;

        // HUD
        public static int HUD_MARGIN = 15;
        public static string LEVEL_GROUP = "level";
        public static string LIVES_GROUP = "lives";
        public static string SCORE_GROUP = "score";
        public static string LEVEL_FORMAT = "LEVEL: {0}";
        public static string LIVES_FORMAT = "LIVES: {0}";
        public static string SCORE_FORMAT = "SCORE: {0}{1}";

        // // BALL
        // public static string BALL_GROUP = "balls";
        // public static string BALL_IMAGE = "Assets/Images/000.png";
        // public static int BALL_WIDTH = 28;
        // public static int BALL_HEIGHT = 28;
        // public static int BALL_VELOCITY = 6;

        // MARIO
        public static string PLUMBER_GROUP = "plumbers";

        public static List<string> MARIO_IMAGES
            = new List<string>() {
                "Assets/Images/mini_mario01.png",
                "Assets/Images/mini_mario02.png"
                // "Assets/Images/guido01b.png"
                // "Assets/Images/guido04.png"
            };
        public static List<string> LUIGI_IMAGES
            = new List<string>() {
                "Assets/Images/Weegee01.png",
                "Assets/Images/Weegee02.png"
                // "Assets/Images/guido01b.png"
                // "Assets/Images/guido04.png"
            };

        public static int PLUMBER_WIDTH = 32;
        public static int PLUMBER_HEIGHT = 50;
        public static int PLUMBER_RATE = 40;
        public static int PLUMBER_SPEED = 10;
        public static int PLUMBER_JUMP = 5;

        // BRICK
        public static string BRICK_GROUP = "bricks";


        public static Dictionary<string, List<string>> BRICK_IMAGES
            = new Dictionary<string, List<string>>() {
                //null space, Void
                { "v", new List<string>() {
                    "Assets/Images/block50.png"
                } },
                //Ground
                { "g", new List<string>() {
                    "Assets/Images/block30.png"
                } },
                //Blocks
                { "b", new List<string>() {
                    "Assets/Images/block01.png",
                } },
                //bRicks
                { "r", new List<string>() {
                    "Assets/Images/bricks.png"
                } },
                //Stone blocks
                { "s", new List<string>() {
                    "Assets/Images/stoneBlock01.png"
                } },
                //Pipes
                { "p", new List<string>() {
                    "Assets/Images/pipe01.png"
                } }
        };

        public static int BRICK_WIDTH = 50;
        public static int BRICK_HEIGHT = 50;
        public static double BRICK_DELAY = 0.5;
        public static int BRICK_RATE = 4;
        public static int BRICK_POINTS = 50;

        // DIALOG
        public static string DIALOG_GROUP = "dialogs";
        public static string ENTER_TO_START = "PRESS ENTER TO START (10$)";
        public static string PREP_TO_LAUNCH = "Let's-a-go!";
        public static string WAS_GOOD_GAME = "GAME OVER";

    }
}