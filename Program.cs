
using DelegatesExample;
using UserDetailsLibrary;

UserDetails objUser = new UserDetails();
//Assigning Functions from UserDetails class to delegate
Details delObj = objUser.PrintName;
delObj += objUser.PrintAge;
delObj += objUser.PrintGender;

UserContactDetails objCus = new UserContactDetails();
//Assigning Functions from UserContactDetails class to delegate
delObj += objCus.PrintEmail;
delObj += objCus.PrintPhone;

PrintUserDetails objPrint = new PrintUserDetails();
//Calling all the assigned functions to the delegate
objPrint.Print(delObj);