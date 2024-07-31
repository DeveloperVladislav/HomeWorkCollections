using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace HomeWorkCollections
{
	public class Program
	{
		//Список List<T>
		public static void ListExample()
		{
			List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

			Console.WriteLine("Список чисел:");
			foreach (int number in numbers)
			{
				Console.WriteLine(number);
			}
		}


		//Двухсвязный список LinkedList<T>
		public static void LinkedListExample()
		{
			LinkedList<string> names = new LinkedList<string>();
			names.AddFirst("Alice");
			names.AddLast("Bob");
			names.AddAfter(names.First, "Charlie");

			Console.WriteLine("Двухсвязный список имен:");
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}
		}


		//Очередь Queue<T>
		public static void QueueExample()
		{
			Queue<int> queue = new Queue<int>();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);

			Console.WriteLine("Очередь чисел:");
			while (queue.Count > 0)
			{
				Console.WriteLine(queue.Dequeue());
			}
		}


		//Стек Stack<T>
		public static void StackExample()
		{
			Stack<string> stack = new Stack<string>();
			stack.Push("Apple");
			stack.Push("Banana");
			stack.Push("Cherry");

			Console.WriteLine("Стек фруктов:");
			while (stack.Count > 0)
			{
				Console.WriteLine(stack.Pop());
			}
		}


		//Словарь Dictionary<T, V>
		public static void DictionaryExample()
		{
			Dictionary<string, int> ages = new Dictionary<string, int>();
			ages["Alice"] = 25;
			ages["Bob"] = 30;
			ages["Charlie"] = 20;

			Console.WriteLine("Словарь имен и возрастов:");
			foreach (KeyValuePair<string, int> kvp in ages)
			{
				Console.WriteLine($"{kvp.Key}: {kvp.Value}");
			}
		}


		//Класс ObservableCollection
		public static void People_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
				case NotifyCollectionChangedAction.Add: // если добавление
					if (e.NewItems?[0] is Person newPerson)
						Console.WriteLine($"Добавлен новый объект: {newPerson.Name}");
					break;
				case NotifyCollectionChangedAction.Remove: // если удаление
					if (e.OldItems?[0] is Person oldPerson)
						Console.WriteLine($"Удален объект: {oldPerson.Name}");
					break;
				case NotifyCollectionChangedAction.Replace: // если замена
					if ((e.NewItems?[0] is Person replacingPerson) &&
						(e.OldItems?[0] is Person replacedPerson))
						Console.WriteLine($"Объект {replacedPerson.Name} заменен объектом {replacingPerson.Name}");
					break;
			}
		}


		//Интерфейсы IEnumerable и IEnumerator
		public static void IEnumerableExample()
		{
			List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

			IEnumerable<int> enumerable = numbers;
			foreach (int number in enumerable)
			{
				Console.WriteLine(number);
			}
			Console.WriteLine();

			IEnumerator<int> enumerator = numbers.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Console.WriteLine(enumerator.Current);
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			//Список List<T>
			Console.WriteLine("--------------------Список List<T>");
			ListExample();


			//Двухсвязный список LinkedList<T>
			Console.WriteLine("--------------------Двухсвязный список LinkedList<T>");
			LinkedListExample();


			//Очередь Queue<T>
			Console.WriteLine("--------------------Очередь Queue<T>");
			QueueExample();


			//Стек Stack<T>
			Console.WriteLine("--------------------Стек Stack<T>");
			StackExample();


			//Словарь Dictionary<T, V>
			Console.WriteLine("--------------------Словарь Dictionary<T, V>");
			DictionaryExample();


			//Класс ObservableCollection
			Console.WriteLine("--------------------Класс ObservableCollection");
			var people1 = new ObservableCollection<Person>()
			{
				new Person("Tom"),
	            new Person("Sam")
			};

			// подписываемся на событие изменения коллекции
			people1.CollectionChanged += People_CollectionChanged;

			people1.Add(new Person("Bob"));  // добавляем новый элемент

			people1.RemoveAt(1);                 // удаляем элемент
			people1[0] = new Person("Eugene");   // заменяем элемент

			Console.WriteLine("\nСписок пользователей:");
			foreach (var person in people1)
			{
				Console.WriteLine(person.Name);
			}


			//Интерфейсы IEnumerable и IEnumerator
			Console.WriteLine("--------------------Интерфейсы IEnumerable и IEnumerator");
			IEnumerableExample();


			//Итераторы и оператор yield
			Console.WriteLine("--------------------Итераторы и оператор yield");
			Numbers numbers = new Numbers();
			foreach (int n in numbers)
			{
				Console.WriteLine(n);
			}


			//Класс Array и массивы
			Console.WriteLine("--------------------Класс Array и массивы");
			string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

			Array.Sort(people, 1, 3);

			Console.WriteLine("===Sort===");
			foreach (var person in people)
				Console.Write($"{person} ");
			
			Console.WriteLine("\n===Copy===");
			var employees = new string[4];

			Array.Copy(people, 1, employees, 0, 4);
			foreach (var person in employees)
				Console.Write($"{person} ");

			Console.WriteLine("\n===Resize===");
			Array.Resize(ref people, 2);

			foreach (var person in people)
				Console.Write($"{person} ");

			Console.WriteLine("\n===Reverse===");
			Array.Reverse(people);
			foreach (var person in people)
				Console.Write($"{person} ");

			Console.WriteLine("\n===IndexOf===");
			int[] nums = { 2, 5, 8, 1, 9, 4 };
			int number = 9;
			int index = Array.IndexOf(nums, number);

			foreach(var num in nums)
			{
				Console.Write($"{num} ");
			}

			if (index != -1)
			{
				Console.WriteLine($"\nИндекс элемента {number} равен {index}");
			}
			else
			{
				Console.WriteLine($"Элемент {number} не найден в массиве");
			}

			Console.WriteLine("===Array.Find===");
			int evenNumber = Array.Find(nums, n => n % 2 == 0);

			if (evenNumber != 0)
			{
				Console.WriteLine($"Первое четное число в массиве: {evenNumber}");
			}
			else
			{
				Console.WriteLine("В массиве нет четных чисел");
			}
		}
	}
}