using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UserCollections03
{
    
    class PersonCollection:IEnumerable,IEnumerator
    { 
        private Person[] _persons;
        private int position = -1;

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (position < _persons.Length - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object? Current => _persons[position];

        public override bool Equals(object? obj) //переопределил т.к. в условии указано, но имхо это не оптимально
        {
            Person person = (Person) obj;
            foreach (var i in _persons)
            {
                if (person != null && i.Pasport == person.Pasport)
                    return true;
            }

            return false;
        }

        public string Add(Person person)
        {
            string msg = "element did not add";
            if (_persons == null)
            {
                _persons = new[] {person};
                msg ="1";
            }
            else
            {
                if (!Equals(person))
                {
                    Person[] newPersons = new Person[_persons.Length+1];
                    if (person is Retiree)
                    {
                        newPersons[0] = person;
                        for (int i = 1; i < newPersons.Length; i++)
                        {
                            newPersons[i] = _persons[i - 1];
                        }

                        msg = "1";
                    }

                    else
                    {
                        for (int i = 0; i < _persons.Length; i++)
                        {
                            newPersons[i] = _persons[i];
                        }

                        newPersons[^1] = person;
                        msg = $"{newPersons.Length}";
                    }

                    _persons = newPersons;
                }
            }

            Console.WriteLine(msg);
            return msg;
        }

        public void Dell()
        {
            Array.Resize(ref _persons,_persons.Length-1);
        }

        public void Dell(Person person)
        {
            int pos = -1;

            for (int i = 0; i < _persons.Length; i++)
            {
                if (person.Pasport == _persons[i].Pasport)
                {
                    pos = i;
                    break;
                }
            }

            if (pos != -1)
            {
                Person[] newPersons = new Person[_persons.Length-1];

                for (int i = 0; i < newPersons.Length; i++)
                {
                    if (i < pos)
                    {
                        newPersons[i] = _persons[i];
                    }
                    else
                    {
                        newPersons[i] = _persons[i + 1];
                    }
                }

                _persons = newPersons;
                return;
            }
            Console.WriteLine($"{person.Show()}\nnot found");
        }

        public ArrayList Contains(Person person) // что бы венуть bool и int решил вернуть коллекцию. 
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < _persons.Length; i++)
            {
                if (person.Pasport == _persons[i].Pasport)
                {
                    list.Add(true);
                    list.Add(i);
                    return list;
                }
            }

            list.Add(false);
            return list;
        }

        public ArrayList ReturnLast()
        {
            ArrayList person = new ArrayList();
            person.Add(_persons[^1]);
            person.Add(_persons.Length);

            return person;
        }

        public void Clear()
        {
            _persons = null;
        }
    }
}
