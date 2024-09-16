string enjoymentLevel = GetEnjoymentLevel();
string userStad = GetStadiumRecommendation(enjoymentLevel);
string userGame = GetGameRecommendation(userStad);
DisplayStadiumDetails(userStad, userGame);


//Prompts the user for the enjoyment level of the game they want to attend and returns the value
static string GetEnjoymentLevel(){
    string enjoymentLevel;
    System.Console.WriteLine("Please enter the enjoyment level you wish to experience:");
    return enjoymentLevel = System.Console.ReadLine();
}

//Determines the best stadium to attend based off the enjoyment level and returns it
static string GetStadiumRecommendation(string enjoymentLevel){
    string userStad;
    if (enjoymentLevel == "Boring"){
        return userStad = "Neyland Stadium";
    } else if(enjoymentLevel == "Average"){
        return userStad = "Jordan-Hare Stadium";
    } else if(enjoymentLevel == "Fun"){
        return userStad = "Tiger Stadium";
    } else if(enjoymentLevel == "Epic"){
        return userStad = "Saban Field at Bryant-Denny Stadium";
    }/* else{
        userStad = "Neyland Stadium";
    }*/
    return null;
}

//Determines the best game to attend based on the stadium given and returns it.
static string GetGameRecommendation(string userStad){
    string userGame;
    string ney = "Neyland Stadium";
    string jhs = "Jordan-Hare Stadium";
    string ts = "Tiger Stadium";
    string sfabds = "Saban Field at Bryant-Denny Stadium";
    if (userStad == ney){
        return userGame = "vs Kent State";
    } else if(userStad == jhs){
        return userGame = "vs Kentucky";
    } else if(userStad == ts){
        return userGame = "vs Alabama";
    } else if(userStad == sfabds){
        return userGame = "vs Auburn";
    }/* else{
        a
    }*/
    return null;
}

//Returns a message detailing the college stadium, including the name of the stadium and the best game to attend.
static void DisplayStadiumDetails(string userStad, string userGame){
    System.Console.WriteLine($"The game is at {userStad} {userGame}");
}

