# zlozone-typy-danych
Zrozumienie złożonych typów danych w C#
W języku C# złożone typy danych to typy, które mogą zawierać więcej niż jedną wartość lub zawierać inne typy danych w swojej definicji. Te typy obejmują struktury, klasy, tablice, kolekcje i typy ogólne. Przyjrzyjmy się bliżej każdemu z tych złożonych typów danych i struktur.

1. Struktury
Struktury to typy wartości, które umożliwiają grupowanie zmiennych różnych typów pod jedną nazwą. Stosuje się je wtedy, gdy potrzebujemy lekkiej alternatywy dla zajęć. Struktury są przechowywane na stosie i są zwykle używane do prostych danych, takich jak punkty 2D, współrzędne lub kolory.

2. Klasy
Klasy są typami referencyjnymi. Są one używane w przypadku bardziej złożonych struktur danych, które mogą zawierać metody, właściwości i inne elementy. Klasy są przechowywane na stercie, co oznacza, że mogą być współużytkowane przez wiele odwołań i zmieniane dynamicznie.

3. Tablice
Tablice w języku C# to struktury danych, które umożliwiają przechowywanie elementów tego samego typu w zorganizowany sposób. Tablice mogą być jednowymiarowe, wielowymiarowe lub zagnieżdżone (tablice tablicowe).

Kolekcje w języku C#
Kolekcje w języku C# to kolekcje obiektów, które umożliwiają dynamiczne zarządzanie danymi. Są bardziej elastyczne niż tablice, ponieważ mogą zmieniać swój rozmiar podczas działania programu i oferują bardziej zaawansowane operacje, takie jak dodawanie, usuwanie i wyszukiwanie elementów. Kolekcje są częścią przestrzeni nazw "System.Collections" i "System.Collections.Generic" (dla kolekcji ogólnych).

Typy kolekcji w C#
Kolekcje można podzielić na dwie kategorie:

Kolekcje niegeneryczne (np. 'ArrayList', 'Hashtable') — pozwalają na przechowywanie elementów różnych typów.
Kolekcje ogólne (np. 'Lista') - Bardziej typowe, co oznacza, że działają tylko z jednym określonym typem danych.
Przyjrzyjmy się najważniejszym kolekcjom używanym w języku C#.

1. 'Lista '
Lista jest najczęściej używaną kolekcją. Przechowuje elementy jednego typu (dzięki generykom), umożliwiając dynamiczne dodawanie, usuwanie i manipulowanie elementami.

Zalety:
Dynamiczne zarządzanie rozmiarem.
Dostęp według indeksu (jak w tablicy).
Typowanie (kompilator sprawdza typ danych).
Główne metody:
'Add(T item)' - Dodaje element do listy.
'Remove(T item)" - Usuwa pierwsze wystąpienie elementu.
'Contains(T item)" - Sprawdza, czy lista zawiera element.
"Liczba" — zwraca liczbę elementów na liście.
2. 'Słownik<TKey, TValue>' (Słownik)
Słownik to kolekcja, w której są przechowywane pary klucz-wartość. Pozwala na szybki dostęp do danych w oparciu o unikalny klucz.

Zalety:
Szybki dostęp do danych opartych na kluczach.
Klucze muszą być unikatowe.
Główne metody:
'Add(TKey key, TValue value)' - Dodaje parę klucz-wartość.
'Remove(TKey key)' - Usuwa parę na podstawie klucza.
'ContainsKey(TKey key)' - Sprawdza, czy słownik zawiera klucz.
'TryGetValue(TKey key, out TValue value)' - Próbuje uzyskać wartość dla danego klucza.
3. 'Kolejka' (kolejka)
Kolejka to kolekcja, która działa zgodnie z zasadą FIFO (First In, First Out), czyli pierwszy dodany element jest pierwszym do usunięcia.

Zalety:
Idealny do przechowywania danych, które muszą być przetwarzane w kolejności dodawania.
Główne metody:
'Enqueue(T item)" - Dodaje element na końcu kolejki.
'Dequeue()' - Usuwa pierwszy element z kolejki.
'Peek()' - Zwraca pierwszy element bez jego usuwania.
4. 'Stos' (Stos)
Stos to kolekcja, która działa zgodnie z zasadą LIFO (Last In, First Out), czyli ostatni dodany element jest pierwszym do usunięcia.

Zalety:
Przydatne w przypadku operacji, w których ostatni dodany element musi zostać przetworzony jako pierwszy.
Główne metody:
'Push(T item)" - Dodaje przedmiot na wierzch stosu.
'Pop()' - Usuwa przedmiot z góry stosu.
'Peek()' - Zwraca element znajdujący się na górze stosu bez jego usuwania.
5. "Zestaw skrótów"
HashSet to kolekcja, która przechowuje unikalne elementy, tzn. każdy element w zestawie występuje tylko raz.

Zalety:
Szybko sprawdź, czy element znajduje się w zestawie.
Elementy są niepowtarzalne.
Główne metody:
'Add(T item)" - Dodaje przedmiot do zestawu.
'Remove(T item)" - Usuwa przedmiot z zestawu.
'Contains(T item)" - Sprawdza, czy element istnieje w zestawie.
6. "LinkedList" (Powiązana lista)
Lista pokrewna to kolekcja, w której każdy element jest węzłem zawierającym wskaźnik do następnego (lub poprzedniego) elementu. Pozwala na sprawne wstawianie i usuwanie elementów w dowolnym miejscu na liście.

Zalety:
Efektywnie dodawaj i usuwaj elementy na początku i na końcu listy.
Główne metody:
'AddFirst(T item)' — dodaje element na początku listy.
'AddLast(T item)' - Dodaje element na końcu listy.
'Remove(T item)" - Usuwa określony element.
Zastosowania kolekcji
"Lista" - Idealna do przechowywania elementów, które będą często odczytywane lub modyfikowane. Służy do tworzenia dynamicznych zestawów danych.
'Dictionary<TKey, TValue>' — służy do przechowywania danych, które mają unikalny klucz, np. słowniki, konfiguracje, mapy.
'Kolejka' - Doskonale nadaje się do przetwarzania kolejek zadań, np. w systemach kolejkowania wiadomości.
'Stos' — używany w operacjach na stosie, np. analiza nawiasów, zarządzanie wywołaniami funkcji.
'HashSet' - Najlepszy wybór, jeśli chcesz przechowywać unikalne elementy i szybko sprawdzić, czy element już istnieje.
"LinkedList" — przydatne, gdy często trzeba dodawać lub usuwać elementy na początku lub na końcu listy.
Zadania
Zadanie 1: Punkt struktury 2D
Napisz program, który definiuje strukturę "Punkt", zawierającą pola "X" i "Y" dla współrzędnych w układzie współrzędnych 2D. Dodaj metodę, która oblicza odległość od innego punktu.

Wymagania:
Struktura 'Point' ma zawierać pola 'X', 'Y'.
Dodaj metodę, która oblicza odległość między dwoma punktami.
Napisz program testowy.
Zadanie 2: Klasa samochodu
Napisz program, który definiuje klasę "Car". Klasa powinna przechowywać informacje o marce, modelu i roku produkcji. Dodaj metodę, która wyświetla te informacje.

Wymagania:
Klasa "Samochód" powinna zawierać pola "Marka", "Model", "Rok produkcji".
Dodaj metodę, która wyświetla pełne informacje o samochodzie.
Napisz program do testowania klasy.
Zadanie 3: Tablica liczb
Napisz program, który tworzy tablicę liczb całkowitych, a następnie oblicza sumę wszystkich elementów w tej tablicy.

Wymagania:
Zdefiniuj tablicę liczb całkowitych.
Napisz funkcję, która obliczy sumę wszystkich liczb w tablicy.
Wyświetl wynik w konsoli.
Zadanie 4: Lista pracowników
Napisz program, który tworzy listę, która przechowuje nazwiska pracowników, a następnie umożliwia dodanie nowego pracownika do listy i wyświetlenie wszystkich pracowników.

Wymagania:
Utwórz listę nazwisk pracowników.
Dodaj możliwość dodania pracownika do listy.
Wyświetlanie wszystkich pracowników po każdej operacji dodawania.
