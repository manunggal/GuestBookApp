// Guests book app

using GuestBook;

// get guest information (name, how many companions and their names also)
var guestInfo = WelcomeGuest.getGuestInfo();

string mainGuestName = guestInfo.mainGuest;
int mainGuestCompanion = guestInfo.companionNumbers;
string guestCompanion = guestInfo.companionNames;

// create array of guest companions
string[] guestCompanionArray = WelcomeGuest.createGuestArray(mainGuestName);

// check array
Console.WriteLine(guestCompanionArray);


