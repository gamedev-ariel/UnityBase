//using UnityEngine;

//public class PlayerMapTracker : MonoBehaviour
//{
//    public RectTransform miniMapMarker; // Reference to the marker object in the mini-map
//    public RectTransform miniMap;      // The RectTransform of the mini-map image
//    public float mapScale = 10f;       // Scale factor to translate world position to map position

//    void Update()
//    {
//        // Get the player's position in world space
//        Vector3 playerPosition = transform.position;

//        // Convert the player's position to mini-map coordinates
//        float mapX = playerPosition.x / mapScale;
//        float mapY = playerPosition.z / mapScale; // Use Z because it's the 3D "forward"

//        // Update the marker's position relative to the mini-map
//        miniMapMarker.anchoredPosition = new Vector2(mapX, mapY);
//    }
//}


//using UnityEngine;

//public class PlayerMapTracker : MonoBehaviour
//{
//    public RectTransform miniMapMarker; // Reference to the marker object in the mini-map
//    public RectTransform miniMap;      // The RectTransform of the mini-map image
//    public float mapScale = 10f;       // Scale factor to translate world position to map position
//    public Vector2 mapOffset;          // Offset to center the mini-map properly

//    void Update()
//    {
//        // Get the player's position in world space
//        Vector3 playerPosition = transform.position;

//        // Convert the player's position to mini-map coordinates
//        float mapX = playerPosition.x / mapScale;
//        float mapY = playerPosition.z / mapScale; // Use Z because it's the 3D "forward"

//        // Offset to place the marker relative to the mini-map center
//        Vector2 miniMapCenter = new Vector2(miniMap.rect.width / 2, miniMap.rect.height / 2);
//        Vector2 markerPosition = new Vector2(mapX, mapY) + miniMapCenter + mapOffset;

//        // Update the marker's position relative to the mini-map
//        miniMapMarker.anchoredPosition = markerPosition;
//    }
//}



using UnityEngine;

public class PlayerMapTracker : MonoBehaviour
{
    public RectTransform miniMapMarker; // The marker object in the mini-map
    public RectTransform miniMap;      // The RectTransform of the mini-map
    public float mapScale = 10f;       // Scale factor to convert world position to map position

    void Update()
    {
        // Get the player's world position
        Vector3 playerPosition = transform.position;

        // Convert the player's position to mini-map coordinates
        float mapX = playerPosition.x / mapScale;
        float mapY = playerPosition.z / mapScale; // Using Z for forward/backward movement

        // Center the marker on the mini-map
        Vector2 miniMapCenter = new Vector2(miniMap.rect.width / 2, miniMap.rect.height / 2);
        Vector2 markerPosition = new Vector2(mapX, mapY) + miniMapCenter;

        // Set the marker's anchored position
        miniMapMarker.anchoredPosition = markerPosition;
    }
}
