using System.Text;
namespace KursIShiSaralashAlgoritmlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int[] BubbleSort(int[] array, ref long iterations)
        {
            bool temp = true;
            while (temp)
            {
                temp = false;
                for (int i = 0; i < array.Length - 1; i++)
                {   
                    if (array[i] > array[i + 1])
                    {
                        int swap = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = swap;
                        temp = true;
                        iterations++;
                    }
                }
            }
            return array;
        }
        public static int[] SelectionSort(int[] array, ref long iterations)
        {
            int Length = array.Length;
            int MinIndex;
            for (int i = 0; i < Length - 1; i++)
            {
                MinIndex = i;
                for (int j = i + 1; j < Length; j++)
                {
                    if (array[j] < array[MinIndex])
                    {
                        MinIndex = j;
                        iterations++;
                    }
                }
                if (MinIndex != i)
                {
                    int swap = array[i];
                    array[i] = array[MinIndex];
                    array[MinIndex] = swap;
                    iterations++;
                }
            }
            return array;
        }
        public static int[] InsertionSort(int[] array, ref long iterations)
        {
            int Length = array.Length;
            for (int i = 1; i < Length; i++)
            {
                int CurrentElement = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > CurrentElement)
                {
                    array[j + 1] = array[j];
                    j--;
                    iterations++;
                }
                array[j + 1] = CurrentElement;
                iterations++;
            }
            return array;
        }
        static void QuickSort(int[] arr, int left, int right, ref long iterations)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right, ref iterations);
                QuickSort(arr, left, pivot - 1, ref iterations);
                QuickSort(arr, pivot + 1, right, ref iterations);
            }
        }
        static int Partition(int[] arr, int left, int right, ref long iterations)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {

                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    iterations++;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp1;
            iterations++;
            return i + 1;
        }
        static long BubbleSortingTimeSpent(int[] arr, ref long iterations)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            BubbleSort(arr, ref iterations);

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
        static long InsertionSortingTimeSpent(int[] arr, ref long iterations)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            InsertionSort(arr, ref iterations);

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
        static long SelectionSortingTimeSpent(int[] arr, ref long iterations)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            SelectionSort(arr, ref iterations);

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
        static long QuickSortingTimeSpent(int[] arr, int left, int right, ref long iterations)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            QuickSort(arr, left, right, ref iterations);

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
        static long Min(long[] arr)
        {
            long min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
        private void SortingButton_Click_1(object sender, EventArgs e)
        {
            int[] NumbersArr;
            int[] CopyNumbersArr1;
            int[] CopyNumbersArr2;
            int[] CopyNumbersArr3;
            int[] CopyNumbersArr4;
            var watch = new System.Diagnostics.Stopwatch();
            if (InputStyleKeyboard.Checked == true)
            {
                string str = Convert.ToString(ElementsBox.Text);
                string[] StringNumbersArr = str.Split();
                NumbersArr = new int[StringNumbersArr.Length];
                CopyNumbersArr1 = new int[StringNumbersArr.Length];
                CopyNumbersArr2 = new int[StringNumbersArr.Length];
                CopyNumbersArr3 = new int[StringNumbersArr.Length];
                CopyNumbersArr4 = new int[StringNumbersArr.Length];
                for (int i = 0; i < NumbersArr.Length; i++)
                {
                    try
                    {
                        NumbersArr[i] = Convert.ToInt32(StringNumbersArr[i]);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("       Elementlarni kiritishda xatolik yuz berdi!!!\r\nIltimos elementlarni probel bilan ajratgan holda kiriting", "Xatolik", MessageBoxButtons.OK);
                        return;
                    }
                    CopyNumbersArr1[i] = NumbersArr[i];
                    CopyNumbersArr2[i] = NumbersArr[i];
                    CopyNumbersArr3[i] = NumbersArr[i];
                    CopyNumbersArr4[i] = NumbersArr[i];
                }
            }
            else
            {
                StringBuilder str = new StringBuilder();
                int n =1000;
                NumbersArr = new int[n];
                CopyNumbersArr1 = new int[n];
                CopyNumbersArr2 = new int[n];
                CopyNumbersArr3 = new int[n];
                CopyNumbersArr4 = new int[n];
                Random r = new Random();
                for (int i = 0; i < NumbersArr.Length; i++)
                {
                    NumbersArr[i] = r.Next(1, 1001);
                    CopyNumbersArr1[i] = NumbersArr[i];
                    CopyNumbersArr2[i] = NumbersArr[i];
                    CopyNumbersArr3[i] = NumbersArr[i];
                    CopyNumbersArr4[i] = NumbersArr[i];
                    str.Append($"{NumbersArr[i]} ");
                }
            ElementsBox.Text = str.ToString();
            }
            long iter1 = 0;
            long time1 = BubbleSortingTimeSpent(CopyNumbersArr1, ref iter1);
            long iter2 = 0;
            long time2 = InsertionSortingTimeSpent(CopyNumbersArr2, ref iter2);
            long iter3 = 0;
            long time3 = SelectionSortingTimeSpent(CopyNumbersArr3, ref iter3);
            long iter4 = 0;
            long time4 = QuickSortingTimeSpent(CopyNumbersArr4, 0, CopyNumbersArr4.Length - 1, ref iter4);
            long[] TimeSpents = new long[4]
            {
                time1 , time2 , time3 , time4 ,
            };
            long[] Iterations = new long[4]
            {
                iter1 , iter2 , iter3 , iter4 ,
            };
            try
            {
                string AlgorithmName = Convert.ToString(AlgorithmNamesList.Text);
                switch (AlgorithmName)
                {
                    case "Bubble Sort":
                        {
                            StringBuilder str = new StringBuilder();
                            AboutAlgorithm.Text = "*Bubble Sort - bu eng oddiy tartiblash algoritmi bo'lib, agar ular noto'g'ri tartibda bo'lsa, ulashgan elementlarni qayta qayta  almashtirish orqali ishlaydi. Ushbu algoritm katta ma'lumotlar  to'plamlari uchun mos emas, chunki uning o'rtacha va eng   yomon vaqt murakkabligi ancha yuqori. Vaqt murakkabligi:      O(n^2). Bubble sort algoritmi g’oyasi Bubble sort algoritmi juda ham oddiy ishlaydi. U shunchaki array boshidan yurib ikkita  qo’shni elementlarni ularning katta kichikligiga qarab joyini almashtiradi. Bu orqali har bir to’liq yurib chiqishdan keyin arraydagi eng katta (yoki eng kichik) element arrayning eng oxiriga o’tib qoladi. Ushbu xusiyatiga ko’ra bu algoritm ba’zida Sink sort (Cho’kib saralash) deb ham ataladi. Lekin, albatta, Bubble sort nomi ko’proq jarangdorroq eshitiladi.Ko’rib turganingizdek algoritm g’oyasi juda ham oddiy. Endi uni qadamma-qadam keltirib o’tamiz.Array boshidan uning oxirgi elementidan bitta oldingi elementigacha yurib chiqamiz.Har bir yurib chiqishda ichki takrorlanish orqali qo’shni elementlarni bir-biri bilan solishtirib, katta elementni o’ng tomonga joylashtirib ketamiz. Har bir tashqi takrorlanish qadami turgagandan so’ng bizda array oxiridan boshlab array saralanib boradi. Shu sababli ha safar ichki takrorlanishda bu qismni qayta ko’rib chiqish shart emas.Tashqi takrorlanish tugaganda bizda saralangan massiv hosil bo’ladi.";
                            foreach (int temp in CopyNumbersArr1)
                            {
                                str.Append($"{temp} ");
                            }
                            SortedNumbers.Text = Convert.ToString($"{str}");
                            CurrentSortingTime.Text = $"{Convert.ToString(time1)}ms";
                            CurrentSortingIterations.Text = Convert.ToString($"{iter1} ta");
                        }
                        break;
                    case "Selection Sort":
                        {
                            StringBuilder str = new StringBuilder();
                            AboutAlgorithm.Text = " *Selection Sort - oddiy va samarali tartiblash algoritmi boʻlib, roʻyxatning tartiblanmagan qismidan eng kichik yoki eng katta elementni qayta-qayta tanlab, uni roʻyxatning tartiblangan qismiga koʻchirish orqali ishlaydi. Vaqt murakkabligi: Tanlash tartibining vaqt murakkabligi O(n^2) ga teng , chunki ikkita ichki oʻrnatilgan tsikl mavjud. Selection sort - Tanlab saralash bu -ddiy tartiblash algoritmidir. Ushbu tartiblash algoritmi oʻz joyida taqqoslashga asoslangan algoritm boʻlib, unda roʻyxat ikki qismga boʻlinadi, tartiblangan qism chap tomonda va tartiblanmagan qism oʻng tomonda. Dastlab, tartiblangan qism boʻsh, tartiblanmagan qismi esa butun roʻyxatdir.Eng kichik element tartiblanmagan massivdan tanlanadi va eng chap element bilan almashtiriladi va bu element tartiblangan massivning bir qismiga aylanadi. Bu jarayon tartiblanmagan massiv chegarasini bitta element bilan oʻngga siljitishda davom etadi.Ushbu algoritm katta maʼlumotlar toʻplamlari uchun mos emas, chunki uning oʻrtacha va eng yomon holatlari murakabligi 0(n^2), bu yerda n — elementlar soni .\r\n1-qadam − MINni 0-indexli joyga qoʻying\r\n2-qadam − Roʻyxatdagi minimal elementni qidiring\r\n3-qadam − MIN manzilidagi qiymat bilan almashtiring\r\n4-qadam − Keyingi elementga ishora qilish uchun MIN ni oshiring\r\n5-qadam − Roʻyxat tartiblashtirilguncha takrorlang";
                            foreach (int temp in CopyNumbersArr2)
                            {
                                str.Append($"{temp} ");
                            }
                            SortedNumbers.Text = Convert.ToString($"{str}");
                            CurrentSortingTime.Text = $"{Convert.ToString(time3)}ms";
                            CurrentSortingIterations.Text = Convert.ToString($"{iter3} ta");
                        }
                        break;
                    case "Insertion Sort":
                        {
                            StringBuilder str = new StringBuilder();
                            AboutAlgorithm.Text = "*Insertion Sort - bu oddiy tartiblash algoritmi bo'lib, u sizning qo'lingizda o'yin kartalarini saralash usuliga o'xshash ishlaydi. Massiv deyarli tartiblangan va tartiblanmagan qismga bo'lingan.Saralanmagan qismdan qiymatlar tanlanadi va tartiblangan qismning to'g'ri joyiga joylashtiriladi. Vaqt murakkabligi: O(n^2).Insertion sort — Joylab saralash ham tartibsiz massiv elementlarini saralash uchun moʻljallangan. Uning ishlash algoritmi xuddi qoʻldagi kartani saralashga oʻxshab ketadi. Tartibsiz turgan kartalar ichidan birini olasiz va uni oʻzi turishi kerak boʻlgan joyga joylashtirib qoʻyasiz. Insertion sort ham shu koʻrinishda ishlaydi. Algoritm oldin massiv boshidagi ikkita elementni saralab olib, massivning qolgan elementlarini shunga qarab oʻz oʻrniga joylashtirib chiqadiBu algoritm oddiy amalga  shirilgani  uchun  eng   oddiy algoritmlardan biridir. Insertion sort kichik maʼlumotlarn saralash uchun samarali. Joylab saralash tabiatan moslashuvchan yaʼni qisman saralangan maʼlumotlar toʻplamlari uchun mos keladi. Insertion sort ham Selection sort va Bubble sort kabi O(n^2) vaqt murakkabligi bilan ishlasa ham, lekin ulardan koʻra samaraliroq algoritm hisoblanadi. Aynan, massiv elementlari deyarli saralangan holatda Insertion sort algoritmi Merge sort yoki Quick sort algoritmidan ham koʻra tezroq ishlaydi.";
                            foreach (int temp in CopyNumbersArr3)
                            {
                                str.Append($"{temp} ");
                            }
                            SortedNumbers.Text = Convert.ToString($"{str}");
                            CurrentSortingTime.Text = $"{Convert.ToString(time2)}ms";
                            CurrentSortingIterations.Text = Convert.ToString($"{iter2} ta");
                        }
                        break;
                    case "Quick Sort":
                        {
                            StringBuilder str = new StringBuilder();
                            AboutAlgorithm.Text = "*Quick Sort – bu “Bo‘l va zabt et” algoritmiga asoslangan saralash algoritmi bo‘lib , u elementni aylanma sifatida tanlaydi va berilgan massivni saralangan massivda to‘g‘ri joyiga qo‘yib, berilgan massivni tanlangan pivot atrofida ajratadi. Uning eng yomon vaqt murakkabligi O(n^2) ga ega, bu pivot noto'g'ri tanlanganda yuzaga keladi. Eng yaxshi holat: O(n*log(n)) va u boshqa shunday tezlikda bajariluvchi algoritmlardan tezroq ishlaydi. Tez saralash(Quicksort) algoritmi - Charlz Xoar tomonidan yaratilgan mashxur saralash algoritmidir.\r\nAlgoritmning Ishlash prinspi:\r\n *1. Massivda ixtiyoriy tayanch element tanlaymiz.\r\n *2. Keyin undan kichik yoki teng elementlarni uning chap   tomoniga, katta elementlarni oʻng tomoniga oʻtkazamiz.\r\n *3. 1 va 2-chi qadamlarni tayanch elementning oʻng va chap  tomonlaridagi elementlar uchun qoʻllaymiz.\r\n *Algorimning 2 qadami turlicha boʻlib uning bir nechta realizatsiyalari mavjud. Ayni shu 2 qadamda elementlarni joylashtirish algoritmi tufayli algoritm saralash algoritmlari ichida eng tez ishlaydiganlaridan biridir.";
                            foreach (int temp in CopyNumbersArr4)
                            {
                                str.Append($"{temp} ");
                            }
                            SortedNumbers.Text = Convert.ToString($"{str}");
                            CurrentSortingTime.Text = $"{Convert.ToString(time4)}ms";
                            CurrentSortingIterations.Text = Convert.ToString($"{iter4} ta");
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Algoritm turini tanlamadingiz!", "Xatolik", MessageBoxButtons.OK);
                        }
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Algoritm turini tanlamadingiz!", "Xatolik", MessageBoxButtons.OK);
                return;
            }
            if (iter1 == Min(Iterations))
            {
                TheSmartSortingAlgorithm.Text = "Bubble Sort";
            }
            if (iter2 == Min(Iterations))
            {
                TheSmartSortingAlgorithm.Text = "Insertion Sort";
            }
            if (iter3 == Min(Iterations))
            {
                TheSmartSortingAlgorithm.Text = "Selection Sort";
            }
            if (iter4 == Min(Iterations))
            {
                TheSmartSortingAlgorithm.Text = "Quick Sort";
            }
            if (time1 == Min(TimeSpents))
            {
                TheFastSortingAlgorithm.Text = "Bubble Sort";
            }
            if (time2 == Min(TimeSpents))
            {
                TheFastSortingAlgorithm.Text = "Insertion Sort";
            }
            if (time3 == Min(TimeSpents))
            {

                TheFastSortingAlgorithm.Text = "Selection Sort";
            }
            if (time4 == Min(TimeSpents))
            {
                TheFastSortingAlgorithm.Text = "Quick Sort";
            }
            CompareSortingAlgorithmsTimes.Text = $"Bubble Sort - {time1}ms\r\nInsertion Sort - {time2}ms\r\nSelection Sort - {time3}ms\r\nQuick Sort - {time4}ms";
            CompareSortingAlgorithmsIterations.Text = $"Bubble Sort - {iter1} ta\r\nInsertion Sort - {iter2} ta\r\nSelection Sort - {iter3} ta\r\nQuick Sort - {iter4} ta";
        }
    }
}