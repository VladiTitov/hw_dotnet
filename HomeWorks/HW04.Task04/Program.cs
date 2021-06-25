﻿using System;

namespace HW04.Task04
{
    class Program
    {
        static void Main()
        {
            string poemLine =
                "У неё всё своё — и бельё, и жильё,;Ну, а я ангажирую угол у тёти.;Для неё — всё свободное время моё,;На неё я гляжу из окна, что напротив.;У неё каждый вечер не гаснет окно,;И вчера мне лифтёр рассказал за полбанки:;У неё два знакомых артиста кино;И один популярный артист из «Таганки».;И пока у меня в ихнем ЖЭКе рука,;Про неё я узнал очень много нюансов:;У неё старший брат — футболист «Спартака»,;А отец — референт в Министерстве финансов.; Я скажу, что всегда на футболы хожу,;На «Спартак», — и слова восхищенья о брате.;Я скажу, что с министром финансов дружу;И что сам как любитель играю во МХАТе.;У неё, у неё на окошке — герань,;У неё, у неё — занавески в разводах,; У меня, у меня на окне — ни хера,;Только пыль, только толстая пыль на комодах…;Ничего, я куплю лотерейный билет,; И тогда мне останется ждать так недолго.;И хотя справедливости в мире как нет —;По нему обязательно выиграю «Волгу».;";

            string[] poem = poemLine.Split(';');
            foreach (string p in poem)
            {
                p.ToUpper().Replace('О', 'А');
            }

            Array.ForEach(poem, Console.WriteLine);
        }
    }
}
