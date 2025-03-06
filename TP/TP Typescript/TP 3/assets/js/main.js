import Contact from "./classes/Person.js";
const contacts = [
    new Contact("Albert", "DUPONT", new Date("1985-10-25"), "a.dupont@example.com", "+33 123 456 789", ""),
    new Contact("Hélène", "DUPONT", new Date("1988-06-27"), "h.dupont@example.com", "+33 147 654 852", ""),
    new Contact("John", "SMITH", new Date("1992-04-14"), "j.smith@example.com", "+32 158 943 225", ""),
    new Contact("Clara", "GOMEZ", new Date("1967-09-13"), "c.gomez@example.com", "+33 146 997 254", ""),
    new Contact("Elizabeth", "MARTIN", new Date("1964-02-22"), "e.martin@example.com", "+33 119 788 254", ""),
];
let selectedContact = contacts[0];
const btnAddContacts = document.getElementById("btnAddContact");
const btnEditContacts = document.getElementById("btnEditContact");
const btnDeleteContacts = document.getElementById("btnDeleteContact");
const contactsContainer = document.getElementById("contactsContainer");
const addContactModal = document.getElementById("addContactModal");
const closeAddContactCross = document.getElementById("addContactClose");
const formAddContact = document.getElementById("formAddContact");
const editContactModal = document.getElementById("editContactModal");
const closeEditContactCross = document.getElementById("editContactClose");
const formEditContact = document.getElementById("formEditContact");
const refreshContactContainer = () => {
    contactsContainer.innerHTML = "";
    contacts.forEach(contact => {
        const newButton = document.createElement('button');
        newButton.textContent = contact.fullname;
        newButton.className = contact === selectedContact ? "btn btn-light w-100 my-2" : "btn btn-outline-light w-100 my-2";
        newButton.addEventListener('click', () => {
            selectedContact = contact;
            refreshContactContainer();
            refreshContactInfos();
        });
        contactsContainer.appendChild(newButton);
    });
};
const refreshContactInfos = () => {
    const firstnameEl = document.getElementById("details-firstname");
    const lastnameEl = document.getElementById("details-lastname");
    const avatarEl = document.getElementById("details-avatarURL");
    const dateOfBirthEl = document.getElementById("details-dateOfBirth");
    const ageEl = document.getElementById("details-age");
    const emailEl = document.getElementById("details-email");
    const phoneNumberEl = document.getElementById("details-phoneNumber");
    firstnameEl.value = selectedContact ? selectedContact.firstname : "";
    lastnameEl.value = selectedContact ? selectedContact.lastname : "";
    dateOfBirthEl.value = selectedContact ? selectedContact.dateOfBirth.toLocaleDateString() : "";
    emailEl.value = selectedContact ? selectedContact.email : "";
    phoneNumberEl.value = selectedContact ? selectedContact.phoneNumber : "";
    avatarEl.src = selectedContact ? selectedContact.avatarURL : "./assets/img/unknown.jpg";
    ageEl.textContent = selectedContact ? `${selectedContact.age}yo` : "";
};
btnDeleteContacts.addEventListener('click', () => {
    if (confirm("Are you sure?")) {
        contacts.splice(contacts.indexOf(selectedContact), 1);
        selectedContact = undefined;
        refreshContactContainer();
        refreshContactInfos();
    }
});
btnAddContacts.addEventListener('click', () => {
    addContactModal.style.display = "block";
});
btnEditContacts.addEventListener('click', () => {
    if (selectedContact) {
        editContactModal.style.display = "block";
        const firstnameEl = document.getElementById("edit-firstname");
        const lastnameEl = document.getElementById("edit-lastname");
        const avatarEl = document.getElementById("edit-avatarURL");
        const dateOfBirthEl = document.getElementById("edit-dateOfBirth");
        const emailEl = document.getElementById("edit-email");
        const phoneNumberEl = document.getElementById("edit-phoneNumber");
        firstnameEl.value = selectedContact.firstname;
        lastnameEl.value = selectedContact.lastname;
        dateOfBirthEl.value = selectedContact.dateOfBirth.toLocaleDateString().split("/").reverse().join("-");
        emailEl.value = selectedContact.email;
        phoneNumberEl.value = selectedContact.phoneNumber;
        avatarEl.value = selectedContact.avatarURL;
    }
});
window.addEventListener('click', (e) => {
    if (e.target === addContactModal) {
        addContactModal.style.display = "none";
    }
    else if (e.target === editContactModal) {
        editContactModal.style.display = "none";
    }
});
closeAddContactCross.addEventListener('click', () => {
    addContactModal.style.display = "none";
});
closeEditContactCross.addEventListener('click', () => {
    editContactModal.style.display = "none";
});
formAddContact.addEventListener('submit', (e) => {
    e.preventDefault();
    const firstnameEl = document.getElementById("add-firstname");
    const lastnameEl = document.getElementById("add-lastname");
    const dateOfBirthEl = document.getElementById("add-dateOfBirth");
    const emailEl = document.getElementById("add-email");
    const phoneNumberEl = document.getElementById("add-phoneNumber");
    const avatarEl = document.getElementById("add-avatarURL");
    const newContact = new Contact(firstnameEl.value, lastnameEl.value, new Date(dateOfBirthEl.value.split("/").reverse().join("-")), emailEl.value, phoneNumberEl.value, avatarEl.value);
    contacts.push(newContact);
    refreshContactContainer();
    addContactModal.style.display = "none";
});
formEditContact.addEventListener('submit', (e) => {
    e.preventDefault();
    const firstnameEl = document.getElementById("edit-firstname");
    const lastnameEl = document.getElementById("edit-lastname");
    const avatarEl = document.getElementById("edit-avatarURL");
    const dateOfBirthEl = document.getElementById("edit-dateOfBirth");
    const emailEl = document.getElementById("edit-email");
    const phoneNumberEl = document.getElementById("edit-phoneNumber");
    selectedContact.firstname = firstnameEl.value;
    selectedContact.lastname = lastnameEl.value;
    selectedContact.avatarURL = avatarEl.value;
    selectedContact.email = emailEl.value;
    selectedContact.phoneNumber = phoneNumberEl.value;
    selectedContact.dateOfBirth = new Date(dateOfBirthEl.value.split("/").reverse().join("-"));
    editContactModal.style.display = "none";
    refreshContactContainer();
    refreshContactInfos();
});
refreshContactContainer();
refreshContactInfos();
