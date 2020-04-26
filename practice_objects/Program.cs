using System;

namespace practice_objects
{

    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Book();
            b1.title = "海辺のカフカ";
            b1.author = "村上春樹";
            Console.WriteLine(b1.Show());
            b1.Show2();
            //countはprivateフィールドなのでアクセス不可
            //Console.WriteLine(b1.count);

            var b2 = new Book();
            b2.title = "春の雪";
            b2.author = "三島由紀夫";
            b2.yonda = true;
            Console.WriteLine($"{b2.title}:{b2.author}:{b2.yonda}");

            var t1 = new Test();
            t1.name1 = "愛子さん";
            t1.name2 = "ユウスケさん";
            Console.WriteLine(t1.Friends("タケシ"));
            Console.WriteLine(t1.Friends(1));
        }

    }

    class Test
    {
        public string name1;
        public string name2;
        //メソッドに引数渡しながら呼び出し
        public string Friends(string x)
        {
            return $"{x}は{name1}と{name2}と仲が良い";
        }
        //同じ名前のメソッドでも引数のデータ型や個数が違っていれば定義可能＝オーバーロード
        public string Friends(int x)
        {
            return $"{x}";
        }
    }

    class Book
    {
        //フィールドを定義
        public string title;
        public string author;
        //bool型のフィールドには規定値がある。デフォはfalse
        public bool yonda;
        //同じクラスからのみアクセス可能なフィールド。他クラス内インスタンス生成してもアクセスできない
        private int count = 0;

        //メソッド定義。返り値有りバージョン
        //フィールド値を操作する
        public string Show()
        {
            return $"{this.title}は{this.author}の作品です";

        }
        //メソッド定義。返り値がない場合はreturn命令を省略し、返り値の型に「void」を指定する
        public  void Show2()
        {
            Console.WriteLine($"{title}");
            Console.WriteLine($"{count}");
        }


    }


}
