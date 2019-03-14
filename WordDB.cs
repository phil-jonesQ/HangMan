using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{

    class WordDB
    {

        //Random Number Gen Method
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        //Word List
        public string AddWord(string randWord, int category)
        {
            // Category mapping
            // 1 == Names
            // 2 == Animals
            // 3 == Misc

            if (category == 1)
            {
                int rMin = 0;
                int rMax = 83;
                string[] selectWord = new string[rMax];
                selectWord[0] = "LEAH";
                selectWord[1] = "ASHLEY";
                selectWord[2] = "JACK";
                selectWord[3] = "OLIVER";
                selectWord[4] = "HARRY";
                selectWord[5] = "ALFIE";
                selectWord[6] = "CHARLIE";
                selectWord[7] = "THOMAS";
                selectWord[8] = "WILLIAM";
                selectWord[9] = "JOSHUA";
                selectWord[10] = "GEORGE";
                selectWord[11] = "JAMES";
                selectWord[12] = "DANIEL";
                selectWord[13] = "JACOB";
                selectWord[14] = "ETHAN";
                selectWord[15] = "SAMUEL";
                selectWord[16] = "JOSEPH";
                selectWord[17] = "DYLAN";
                selectWord[18] = "MOHAMMED";
                selectWord[19] = "NOAH";
                selectWord[20] = "LUCAS";
                selectWord[21] = "OSCAR";
                selectWord[22] = "ALEXANDER";
                selectWord[23] = "BENJAMIN";
                selectWord[24] = "MAX";
                selectWord[25] = "ARCHIE";
                selectWord[26] = "RILEY";
                selectWord[27] = "JAYDEN";
                selectWord[28] = "LEWIS";
                selectWord[29] = "LOGAN";
                selectWord[30] = "JAKE";
                selectWord[31] = "RYAN";
                selectWord[32] = "MUHAMMAD";
                selectWord[33] = "TYLER";
                selectWord[34] = "LIAM";
                selectWord[35] = "HENRY";
                selectWord[36] = "FINLEY";
                selectWord[37] = "LEO";
                selectWord[38] = "ISAAC";
                selectWord[39] = "LUKE";
                selectWord[40] = "ADAM";
                selectWord[41] = "CALLUM";
                selectWord[42] = "MATTHEW";
                selectWord[43] = "HARRISON";
                selectWord[44] = "EDWARD";
                selectWord[45] = "OLIVIA";
                selectWord[46] = "SOPHIE";
                selectWord[47] = "EMILY";
                selectWord[48] = "LILY";
                selectWord[49] = "AMELIA";
                selectWord[50] = "JESSICA";
                selectWord[51] = "CHLOE";
                selectWord[52] = "GRACE";
                selectWord[53] = "EVIE";
                selectWord[54] = "AVA";
                selectWord[55] = "ISABELLA";
                selectWord[56] = "MIA";
                selectWord[57] = "MAISIE";
                selectWord[58] = "DAISY";
                selectWord[59] = "ISABELLE";
                selectWord[60] = "ELLA";
                selectWord[61] = "FREYA";
                selectWord[62] = "CHARLOTTE";
                selectWord[63] = "ISLA";
                selectWord[64] = "MEGAN";
                selectWord[65] = "SCARLETT";
                selectWord[66] = "IMOGEN";
                selectWord[67] = "SOPHIA";
                selectWord[68] = "PHOEBE";
                selectWord[69] = "ELLIE";
                selectWord[70] = "SUMMER";
                selectWord[71] = "HANNAH";
                selectWord[72] = "MILLIE";
                selectWord[73] = "LOLA";
                selectWord[74] = "ABIGAIL";
                selectWord[75] = "ERIN";
                selectWord[76] = "LACEY";
                selectWord[77] = "EVA";
                selectWord[78] = "AMY";
                selectWord[79] = "LILLY";
                selectWord[80] = "KATIE";
                selectWord[81] = "TONI";
                selectWord[82] = "PHILIP";
                //Get a random number
                int rand = RandomNumber(rMin, rMax);
                //Then pull the word based on index with random number
                randWord = selectWord[rand];
                //return the word
                return randWord;

            }

            if (category == 2)
            {
                int rMin = 0;
                int rMax = 52;
                string[] selectWord = new string[rMax];
                selectWord[0] = "alligator";
                selectWord[1] = "ant";
                selectWord[2] = "bear";
                selectWord[3] = "bee";
                selectWord[4] = "bird";
                selectWord[5] = "camel";
                selectWord[6] = "cat";
                selectWord[7] = "cheetah";
                selectWord[8] = "chicken";
                selectWord[9] = "chimpanzee";
                selectWord[10] = "cow";
                selectWord[11] = "crocodile";
                selectWord[12] = "deer";
                selectWord[13] = "dog";
                selectWord[14] = "dolphin";
                selectWord[15] = "duck";
                selectWord[16] = "eagle";
                selectWord[17] = "elephant";
                selectWord[18] = "fish";
                selectWord[19] = "fly";
                selectWord[20] = "fox";
                selectWord[21] = "frog";
                selectWord[22] = "giraffe";
                selectWord[23] = "goat";
                selectWord[24] = "goldfish";
                selectWord[25] = "hamster";
                selectWord[26] = "hippopotamus";
                selectWord[27] = "horse";
                selectWord[28] = "kangaroo";
                selectWord[29] = "kitten";
                selectWord[30] = "lion";
                selectWord[31] = "lobster";
                selectWord[32] = "monkey";
                selectWord[33] = "octopus";
                selectWord[34] = "owl";
                selectWord[35] = "panda";
                selectWord[36] = "pig";
                selectWord[37] = "puppy";
                selectWord[38] = "rabbit";
                selectWord[39] = "rat";
                selectWord[40] = "scorpion";
                selectWord[41] = "seal";
                selectWord[42] = "shark";
                selectWord[43] = "sheep";
                selectWord[44] = "snail";
                selectWord[45] = "snake";
                selectWord[46] = "spider";
                selectWord[47] = "squirrel";
                selectWord[48] = "tiger";
                selectWord[49] = "turtle";
                selectWord[50] = "wolf";
                selectWord[51] = "zebra";
                //Get a random number
                int rand = RandomNumber(rMin, rMax);
                //Then pull the word based on index with random number
                randWord = selectWord[rand];
                //return the word
                return randWord;
            }
            if (category == 3)
            {
                int rMin = 0;
                int rMax = 118;
                string[] selectWord = new string[rMax];
                selectWord[0] = "About";
                selectWord[1] = "Account";
                selectWord[2] = "Acid";
                selectWord[3] = "Adjustment";
                selectWord[4] = "Advertisement";
                selectWord[5] = "Against";
                selectWord[6] = "Agreement";
                selectWord[7] = "Air";
                selectWord[8] = "All";
                selectWord[9] = "Angle";
                selectWord[10] = "Animal";
                selectWord[11] = "Ant";
                selectWord[12] = "Apple";
                selectWord[13] = "Arch";
                selectWord[14] = "Arm";
                selectWord[15] = "Army";
                selectWord[16] = "Art";
                selectWord[17] = "As";
                selectWord[18] = "Attempt";
                selectWord[19] = "Authority";
                selectWord[20] = "Automatic";
                selectWord[21] = "Baby";
                selectWord[22] = "Bag";
                selectWord[23] = "Ball";
                selectWord[24] = "Band";
                selectWord[25] = "Basin";
                selectWord[26] = "Basket";
                selectWord[27] = "Bed";
                selectWord[28] = "Bee";
                selectWord[29] = "Belief";
                selectWord[30] = "Bell";
                selectWord[31] = "Berry";
                selectWord[32] = "Bird";
                selectWord[33] = "Bit";
                selectWord[34] = "Black";
                selectWord[35] = "Blade";
                selectWord[36] = "Cake";
                selectWord[37] = "Camera";
                selectWord[38] = "Canvas";
                selectWord[39] = "Card";
                selectWord[40] = "Cattle";
                selectWord[41] = "Chain";
                selectWord[42] = "Chalk";
                selectWord[43] = "Clock";
                selectWord[44] = "Coal";
                selectWord[45] = "Color";
                selectWord[46] = "Company";
                selectWord[47] = "Comparison";
                selectWord[48] = "Connection";
                selectWord[49] = "Cook";
                selectWord[50] = "Copy";
                selectWord[51] = "Cotton";
                selectWord[52] = "Country";
                selectWord[53] = "Crime";
                selectWord[54] = "Cry";
                selectWord[55] = "Cup";
                selectWord[56] = "Day";
                selectWord[57] = "Door";
                selectWord[58] = "Drink";
                selectWord[59] = "East";
                selectWord[60] = "Gemstone";
                selectWord[61] = "Idea";
                selectWord[62] = "Judge";
                selectWord[63] = "Jump";
                selectWord[64] = "Like";
                selectWord[65] = "Measure";
                selectWord[66] = "Mix";
                selectWord[67] = "Nature";
                selectWord[68] = "Question";
                selectWord[69] = "Quick";
                selectWord[70] = "Receipt";
                selectWord[71] = "Sleep";
                selectWord[72] = "Street";
                selectWord[73] = "This";
                selectWord[74] = "Ticket";
                selectWord[75] = "Tomorrow";
                selectWord[76] = "True";
                selectWord[77] = "Umbrella";
                selectWord[78] = "Value";
                selectWord[79] = "Vessel";
                selectWord[80] = "Violent";
                selectWord[81] = "Voice";
                selectWord[82] = "Wall";
                selectWord[83] = "War";
                selectWord[84] = "Warm";
                selectWord[85] = "Waste";
                selectWord[86] = "Water";
                selectWord[87] = "Wave";
                selectWord[88] = "Wax";
                selectWord[89] = "Weather";
                selectWord[90] = "Week";
                selectWord[91] = "Weight";
                selectWord[92] = "Well";
                selectWord[93] = "West";
                selectWord[94] = "Wheel";
                selectWord[95] = "Whip";
                selectWord[96] = "Whistle";
                selectWord[97] = "White";
                selectWord[98] = "Wind";
                selectWord[99] = "Window";
                selectWord[100] = "Wine";
                selectWord[101] = "Wing";
                selectWord[102] = "Winter";
                selectWord[103] = "Wire";
                selectWord[104] = "Woman";
                selectWord[105] = "Wood";
                selectWord[106] = "Wool";
                selectWord[107] = "Word";
                selectWord[108] = "Work";
                selectWord[109] = "Worm";
                selectWord[110] = "Writing";
                selectWord[111] = "Year";
                selectWord[112] = "Yellow";
                selectWord[113] = "Yes";
                selectWord[114] = "Yesterday";
                selectWord[115] = "You";
                selectWord[116] = "Young";
                selectWord[117] = "Zoo";

                //Get a random number
                int rand = RandomNumber(rMin, rMax);
                //Then pull the word based on index with random number
                randWord = selectWord[rand];
                //return the word
                return randWord;
            }

            //randWord = "test";
            return randWord;
        }

    }
}
