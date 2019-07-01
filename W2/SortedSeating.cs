public class Guest{
    Guest prev;
    Guest next;
    public string name;

    public Guest(string name)
    {
        this.name  = name;
    }

    public void addGuest(string name){
        if(string.Compare(this.name, name) > 0){  //added name comes first
        var guest = new Guest(name);
        
    }
}

public class JaneList{

    Guest firstGuest;
    public void add(string name){
        if (firstGuest == null){
            firstGuest = new Guest(name);
        }
        else {
            firstGuest.addGuest(name);
        }
    }

    public string get(string name){
        return string.Empty;
    }

    public void delete(string name){

    }
}