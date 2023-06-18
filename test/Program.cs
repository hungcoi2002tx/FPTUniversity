// See https://aka.ms/new-console-template for more information
using test;

UserInput userInput = new UserInput();
TinhCan tinhCan = new TinhCan();
tinhCan.Sub(userInput);
BinhPhuong binhPhuong = new BinhPhuong();
binhPhuong.Sub(userInput);
userInput.Input();
