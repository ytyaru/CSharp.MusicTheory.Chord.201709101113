# このソフトウェアについて

C#で音度からピッチクラスを取得する（変化記号に未対応）。

# Python版

これまでPython版で書いてきた。しかし音楽理論の難しさとPythonの言語仕様に嫌気が差してC#に浮気した。

* [和音名(ChordName)から構成音を音程名(IntervalName)で取得する](http://ytyaru.hatenablog.com/entry/2018/10/04/000000)

なんとかC#に移植できないかと動き始めた。

# 開発環境

* Linux Mint 17.3 MATE 32bit
* [MonoDevelop 4.0.12](http://ytyaru.hatenablog.com/entry/2018/05/25/000000)
* [mono 3.2.8](http://ytyaru.hatenablog.com/entry/2018/05/24/000000) (Debian 3.2.8+dfsg-4ubuntu1.1)
    * mcs(Mono C# compiler) 3.2.8.0
    * csharp(インタプリタ) 4.0.0.0

# C#で忘れていたこと

ほぼすべて忘れている……。

* 配列は使わず`System.Collections.Generic.List<>`を使う
* `static`はグローバル変数ではなくクラス変数である
* 変数の宣言には型が必要
* インスタンスの生成には`new`キーワードが必要

# ライセンス

このソフトウェアはCC0ライセンスである。

[![CC0](http://i.creativecommons.org/p/zero/1.0/88x31.png "CC0")](http://creativecommons.org/publicdomain/zero/1.0/deed.ja)

