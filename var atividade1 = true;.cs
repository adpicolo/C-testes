var atividade1 = true;
var atividade2 = false;
var todas = atividade1 && atividade2;

Console.WriteLine("fez todas as atividades? {0}", todas);
var umaApenas = atividade1 || atividade2;
Console.WriteLine("fez pelo menos uma das atividades? {0}", umaApenas);
Console.WriteLine("não fez nenhuma? {0}", !umaApenas);

//fez todas as atividades? False;
//fez pelo menos uma das atividades? True;
//não fez nenhuma atividade? False