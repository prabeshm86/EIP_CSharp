public class Guest
{
    public Guest prev;
    public Guest next;
    public string name;

    public Guest(string name)
    {
        this.name = name;
    }
}

public class JaneList
{

    Guest firstGuest;
    public void add(string name)
    {
        if (firstGuest == null)
        {
            firstGuest = new Guest(name);
        }

        else
        {
            var guest = new Guest(name);

            var current = firstGuest;

            if (string.Compare(current.name, guest.name) > 0){
                current.prev = guest;
                guest.next = current;
                this.firstGuest = guest;

                return;
            }
                


            while (string.Compare(current.name, name) < 0)
            {
                if (current.next == null)
                    current.next = guest;
                else if (string.Compare(current.next.name, guest.name) > 0)
                {
                    guest.prev = current;
                    guest.next = current.next;
                    current.next = guest;
                    current.next.prev = guest;
                    break;
                }
                else current = current.next;
            }

        }

    }

    public string[] get(string name)
    {
        var curr = firstGuest;
        while (curr != null)
        {
            if (curr.name == name) return new string[] {curr.prev?.name, curr.next?.name};
            
            curr = curr.next;
        }
        return new string[]{};
    }

    public void delete(string name)
    {
        var curr = firstGuest;
        while (curr != null)
        {
            if (curr.name == name) {

               if (curr.prev != null) curr.prev.next = curr.next;
               else firstGuest = curr.next;

               if(curr.next != null) curr.next.prev = curr.prev;
                curr.prev = null;
                curr.next = null;

                break;
            }
            
            curr = curr.next;
        }
    }
}