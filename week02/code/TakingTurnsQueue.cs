/// <summary>
/// This queue is circular. When people are added via AddPerson, then they are added to the
/// back of the queue (per FIFO rules). When GetNextPerson is called, the next person
/// in the queue is saved to be returned and then they are placed back into the back of the queue.
/// </summary>
public class TakingTurnsQueue
{
    private readonly PersonQueue _people = new();

    public int Length => _people.Length;

    public void AddPerson(string name, int turns)
    {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    public Person GetNextPerson()
    {
        if (_people.IsEmpty())
        {
            throw new InvalidOperationException("No one in the queue.");
        }
        else
        {
            Person person = _people.Dequeue();

            if (person.Turns <= 0)
            {
                _people.Enqueue(person);
            }
            else
            {
                person.Turns -= 1;

                if (person.Turns > 0)
                {
                    _people.Enqueue(person);
                }
            }

            return person;
        }
    }

    public override string ToString()
    {
        return _people.ToString();
    }
}