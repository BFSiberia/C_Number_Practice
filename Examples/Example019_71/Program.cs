// Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с»
//и «в». Покажите все слова, состоящие из n букв, которые можно построить из
//букв этого алфавита.
//n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
//ав, ва, ви, ив, св, вс

int a =1; // счетчик слов
void FindWords(string abc, char[] word, int length = 0) // алфавит, массив для слов, длина слова
{
    if (length == word.Length) //условие заверешния рекурсии: если счетчик длины слова = длине массива word
    {
        Console.WriteLine($"{a++} {new String(word)}");// счетчик слова + новое слово
        return;
    }
    for (int i=0; i<abc.Length;i++)
    {
        word[length] = abc[i];
        FindWords(abc,word,length+1);
    }
}
int n=2;
FindWords("аисв", new char[n]);