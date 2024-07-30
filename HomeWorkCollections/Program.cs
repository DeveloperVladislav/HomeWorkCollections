using System.Collections.ObjectModel;

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
		public static void ObservableCollectionExample()
		{
			ObservableCollection<string> items = new ObservableCollection<string>();
			items.Add("Item 1");
			items.Add("Item 2");

			items.CollectionChanged += (sender, e) =>
			{
				Console.WriteLine($"Коллекция изменилась: {e.Action}");
			};

			items.Add("Item 3");

			items.RemoveAt(1);
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
			ObservableCollectionExample();


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

			// сортируем с 1 индекса 3 элемента
			Array.Sort(people, 1, 3);

			foreach (var person in people)
				Console.Write($"{person} ");
		}
	}
}