using System;

public class AddressBook
{
    public Dictionary<string, Contact>? Contacts { get; set; } = new Dictionary<string, Contact>();

    public void AddContact(Contact contact){
        Contacts.Add(contact.Email, contact);
    }

    public Contact GetByEmail(string email){
        var value = Contacts[email];
        return value;
    }
}