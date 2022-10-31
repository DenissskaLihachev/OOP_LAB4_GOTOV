using My_Libs;

ListQueue li = new ListQueue();

//Console.Write("Введите имя: "); string name = Console.ReadLine();
//Console.Write("Введите фамилию: "); string secondname = Console.ReadLine();
//Console.Write("Введите пол: "); string gender = Console.ReadLine();
//Console.Write("Введите возраст: "); int age = Convert.ToInt32(Console.ReadLine());

//Person chel = new Person(name, secondname, gender, age);    //с параметрами
//li.add(chel);
//Console.Clear();
//Console.WriteLine(li.get().ToString());



//Person chel2 = new Person();    //без параметров
//li.add(chel2);
//Console.Clear();
//Console.WriteLine(li.get().ToString());


li.add(new Person("Человеков", "Человек", "Мужчина", 18));
li.add(new Person("Мужчинов", "Мужчин", "Мужчина", 19));
li.add(new Person("Женщинова", "ЕЖенщина", "Женщина", 13));
li.add(new Person("Мальчиков", "Мальчик", "Мужчина", 15));
li.add(new Person("фвфвфц", "фуцаацфа", "Мужчина", 25));

li.GetMassive();

Console.Read();