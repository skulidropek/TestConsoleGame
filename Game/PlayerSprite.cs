using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal static class PlayerSprite
    {
        public static char[,] Sprite;
        
        static PlayerSprite()
        {
            Sprite = new char[5, 5];
            Sprite[0, 0] = ' ';
            Sprite[0, 1] = ' ';
            Sprite[0, 2] = '^';
            Sprite[0, 3] = ' ';
            Sprite[0, 4] = ' ';
            Sprite[1, 0] = ' ';
            Sprite[1, 1] = '-';
            Sprite[1, 2] = '#';
            Sprite[1, 3] = '-';
            Sprite[1, 4] = ' ';
            Sprite[2, 0] = '\\';
            Sprite[2, 1] = '-';
            Sprite[2, 2] = ' ';
            Sprite[2, 3] = '-';
            Sprite[2, 4] = '/';
            Sprite[3, 0] = ' ';
            Sprite[3, 1] = '-';
            Sprite[3, 2] = ' ';
            Sprite[3, 3] = '-';
            Sprite[3, 4] = ' ';
            Sprite[4, 0] = '_';
            Sprite[4, 1] = '|';
            Sprite[4, 2] = ' ';
            Sprite[4, 3] = '|';
            Sprite[4, 4] = '_';
            //     = new char[,]
            //{
            //    { ' ', ' ', '^', ' ', ' ' },
            //    { ' ', '-', '#', '-', ' ' },
            //    { '\\', '-', ' ', '-', '/' },
            //    { ' ', '-', ' ', '-', ' ' },
            //    { '_', '|', ' ', '|', '_' },
            //};
        }

        /*
         * ☺ ☻ ♥ ♦ ♣ ♠ ♫ ☼ ► ◄ ↕ ‼ ¶ § ▬ ↨ ↑ ↓ → ← ∟ ↔ ▲ ▼ ! " # $ % & ' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9 : ; < = >@ A B C D E F G H I J K L M N O P Q R S T U V W X Y Z [ \ ] ^ _ ` a b c d e f g h i j k l m n o p q r s t u v w x y z { | } ~ ⌂  ¤
        │ §c< ┐ - R° +ч ¶ ·> A A A A A AC E E E E I I I IN O O O O OO U U U U Y a a a a a ac e e e e i i i in o o o o oo u u u u yy A a A a A a C c C c C c C c D d D d E e E e E e E e E e G g G g G g G g H h H h I i I i I i I i IJ j K kL l L l L l L l
        N n N n N nO o O o O o R r R r R r S s S s S s S s T t T t T t U u U u U u U u U u U u W w Y y Y Z z Z z Z zb I l O O ot T U u A a I i O o U u U u U u U u U uA a G g G g K k O o O o j Ё Є Ї ЎА Б В Г Д Е Ж З И Й К Л М Н О П Р С Т У Ф Х Ц Ч Ш Щ Ъ
        Ы Ь Э Ю Я а б в г д е ж з и й к л м н о п р с т у ф х ц ч ш щ ъ ы ь э ю яё є ї ў - -' ' '" " "┼ ╪ :% < >‼№T← ↑ → ↓ ↔ ↕ ↨ ∙ √ ∟ ⌂─│┌┐└┘├┤┬┴┼═ ║ ╒ ╓ ╔ ╕ ╖ ╗ ╘ ╙ ╚ ╛ ╜ ╝ ╞ ╟ ╠ ╡ ╢ ╣ ╤ ╥ ╦ ╧ ╨ ╩ ╪ ╫ ╬▀▄█▌▐ ░ ▒ ▓ ■▬▲►▼◄ 
        ☺ ☻ ☼♀♂ ♫! " # $ % & ' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9 : ; < = >@ A B C D E F G H I J K L M N O P Q R S T U V W X Y Z [ \ ] ^ _ ` a b c d e f g h i j k l m n o p q r s t u v w x y z { | } ~
        */
    }
}

