# Polish version README

**Jest to projekt na zaliczenie przedmiotu: "Programowanie obiektowe"!**

**Treść zadania:**

Zaprojektuj i zaimplementuj podstawy komputerowej gry RPG, 
w której może istnieć wiele typów bohaterów. 
Początkowo system będzie obsługiwał tylko trzy rodzaje postaci (wojownik, mag i postać o nazwie zgodnej z inicjałami autora programu), 
jednakże w przyszłości planowane jest rozszerzenie systemu o inne rodzaje bohaterów. 
Wiadomo jednak, że wszystkie postacie będą opisane nazwą, 
posiadają pewien poziom żywotności oraz udostępniają operację pozwalającą obliczyć moc ataku postaci na podstawie parametrów charakteryzujących bohatera.



Zaimplementuj klasy reprezentujące dwa typy postaci opisane następującymi atrybutami:
* Mag: imię, żywotność (w %), siła (liczba całkowita), punty magii (liczba całkowita)
* Wojownik: imię, żywotność (w %), siła (liczba całkowita)
* <inicjały_autora>: imię, żywotność (w %), siła (liczba całkowita), wiek (liczba całkowita – wiek autora)

Zadbaj o właściwą hermetyzację, tzn. pola klas nie powinny być publiczne.

Obiekty reprezentujące bohaterów udostępniają następujące operacje:
* konstruktor pozwalający zainicjować wszystkie pola składowe,
* konstruktor domyślny ustawiający pola obiektów wg schematu:
  - Wojownik: imię = „Geralt”, żywotność = 100%, siła = 3k6 (losowa wartość od 3 do 18, wynik rzutu trzema kostkami),
  - Mag: imię = „Xardas”, żywotność = 100%, siła = 1k6, punkty magii = 2k6,
  - <inicjały_autora>: imię = „Student”, żywotność = 100%, siła = 2k6, wiek = 25
* metodę pozwalającą dodać (odjąć) pewną wartość punktów żywotności. 
Jednak wartość końcowa nie może spaść poniżej 0 i wzrosnąć powyżej 100%. Metoda zwraca nową wartość żywotności.
* metodę zwracającą moc ataku postaci. Zależnie od typu bohatera wynosi ona:
  - dla maga: ( punkty magii + siła ) x żywotność
  - dla wojownika: siła x żywotność , lecz gdy żywotność spadnie poniżej 5% wojownik wpada w szał i jego siła ataku równa się sile bazowej.
* przeciąż metodę ToString() zwracającą napis zawierający informacje o nazwie bohatera oraz wartość żywotności i moc ataku.



Zaimplementuj klasę realizującą drużynę bohaterów. Klasa ta przechowuje dowolnie duży zbiór postaci. Dla tej klasy zaimplementuj operacje:
* konstruktor pozwalający zainicjować drużynę o podanej w argumencie nazwie,
* metodę Clone() implementującą interfejs IClonable. Metoda zwraca wierną kopię obiektu klonowanego.
* metodę dodającą nową postać do drużyny,
* metodę dającą dostęp (możliwość odczytu i modyfikacji) bohatera drużyny o podanym indeksie (może to być dociążony operator [])
* metodę zwracającą sumaryczną wartość mocy ataku wszystkich członków drużyny,
* przeciążoną metodę ToString(), która zwraca napis zawierający nazwę drużyny, sumaryczną moc ataku oraz pełną listę postaci.



Napisz program testujący działanie systemu. 
Utwórz grupę bohaterów o nazwie „Druzyna pierscienia” i umieść w jej składzie przynajmniej po dwie postaci z każdego typu. 
Zmniejsz żywotność jednego z wojowników do 3% i wypisz w terminalu zawartość drużyny: nawę, sumaryczną wartość mocy ataku i listę uczestników grupy.



# English version README

> Translated with www.DeepL.com/Translator

**This is a project for course credit: "Object Oriented Programming"!**

**Content of the task:**

Design and implement the basis of a computer RPG in which there can be multiple types of heroes. 
Initially, the system will support only three types of characters (a warrior, a mage and a character named according to the initials of the author of the programme), 
but in the future it is planned to extend the system to include other types of heroes. 
It is known, however, that all characters will be described with a name, 
have a certain level of vitality and provide an operation to calculate the character's attack power based on parameters characterising the hero.



Implement classes representing two types of characters described by the following attributes:
* Mage: name, vitality (in %), strength (integer), magic points (integer)
* Warrior: name, vitality (%), strength (integer)
* <author_initials>: name, vitality (in %), strength (integer), age (integer - author's age)

Ensure proper encapsulation, i.e. class fields should not be public.

Objects representing heroes provide the following operations:
* a constructor to initialise all component fields,
* a default constructor that sets the object fields according to the schema:
  - Warrior: name = "Geralt", lifespan = 100%, strength = 3k6 (random value from 3 to 18, result of a three-dice roll),
  - Mage: name = "Xardas", vitality = 100%, strength = 1k6, magic points = 2k6,
  - <initials_author>: name = "Student", vitality = 100%, strength = 2k6, age = 25
* a method to add (subtract) a certain value of vitality points. 
However, the final value cannot fall below 0 and increase above 100%. The method returns the new vitality value.
* method returning the character's attack power. Depending on the type of hero, it is:
  - for a mage: ( magic points + strength ) x vitality
  - for a warrior: strength x lifespan , but when the lifespan drops below 5% the warrior goes into a rage and his attack power equals the base power.
* overload the ToString() method that returns a string containing information about the hero's name and the life and attack power values.


Implement a class that implements a team of heroes. This class stores an arbitrarily large collection of characters. Implement operations for this class:
* a constructor to initialise the team with the name given in the argument,
* Clone() method implementing the IClonable interface. The method returns an exact copy of the object to be cloned.
* a method that adds a new character to the team,
* a method that gives access (read and modify) to a team character with the given index (this can be the [] operator)
* a method that returns the summed attack power value of all team members,
* an overloaded ToString() method that returns a string containing the team name, the summed attack power and the full list of characters.



Write a program to test the operation of the system. 
Create a group of heroes called "Team of the Ring" and include at least two characters of each type. 
Reduce the lifespan of one of the warriors to 3% and write out the contents of the team in the terminal: aisle, total attack power and list of group members.
