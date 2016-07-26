//For placing the image of the mini map.
var miniMap : GUIStyle;
//Two transform variables, one for the player's and the enemy,
var player : Transform;
var enemy : Transform;
//Icon images for the player and enemy(s) on the map.
var playerIcon : GUIStyle;
var enemyIcon : GUIStyle;
//Offset variables (X and Y) - where you want to place your map on screen.
var mapOffSetX=362;
var mapOffSetY =480;
//The width and height of your map as it'll appear on screen,
var mapWidth =300;
var mapHeight =300;
//Resolution (both width and height) of your terrain.
var sceneWidth =1600;
var sceneHeight =1600;
//The size of your player and enemy's icon as it would appear on the map.
var iconSize =10;
var iconHalfSize;

function Update () {
iconHalfSize = iconSize/2;
}

function GetMapPos(pos : float, mapSize : float, sceneSize : float) {
return pos * mapSize/sceneSize;
}

function OnGUI() {
//Everything about the map.
GUI.BeginGroup(Rect(mapOffSetX,mapOffSetY,mapWidth,mapHeight), miniMap);
var pX = GetMapPos(transform.position.x, mapWidth, sceneWidth);
var pY = GetMapPos(transform.position.y, mapHeight, sceneHeight);
var playerMapX = pX - iconHalfSize;
var playerMapY = (-pY + iconHalfSize)-10;
GUI.Box(Rect(playerMapX, playerMapY, iconSize, iconSize), "", playerIcon);
  
var sX = GetMapPos(enemy.transform.position.x, mapWidth, sceneWidth);
var sY = GetMapPos(enemy.transform.position.y, mapHeight, sceneHeight);
var enemyMapX = sX - iconHalfSize;
var enemyMapY = (-sY + iconHalfSize)-10;
GUI.Box(Rect(enemyMapX, enemyMapY, iconSize, iconSize), "", enemyIcon);
GUI.EndGroup();
}