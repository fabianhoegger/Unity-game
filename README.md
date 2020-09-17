# Unity-game
## Αναφορά
## Φάμπιαν Χαίγκερ ,ΑΜ:2016187
### Περιγραφή
3d Person Action Game
-Στόχος clear the zombies from Γαριτσα
hand combat
enemy ai -navmesh + triggers

### Πακέτα που χρησιμοποιήσα
1. [Cinemachine](https://unity.com/unity/features/editor/art-and-design/cinemachine) -Κάμερα
2. [BodyGuards](https://assetstore.unity.com/packages/3d/characters/humanoids/humans/bodyguards-31711) prefab
3. [Zombie](https://assetstore.unity.com/packages/3d/characters/humanoids/zombie-30232) Prefab
4. [ADG_Textures](https://assetstore.unity.com/packages/2d/textures-materials/brick/18-high-resolution-wall-textures-12567)
5. [Standard Asset](https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2018-4-32351) water prefab
6. [AllSky](https://assetstore.unity.com/packages/2d/textures-materials/sky/allsky-free-10-sky-skybox-set-146014) skybox
7. [Conifers](https://assetstore.unity.com/packages/3d/vegetation/trees/conifers-botd-142076) 
8. [Flooded Grounds](https://assetstore.unity.com/packages/3d/environments/flooded-grounds-48529)


### Τεχνικες Optimization
- Χαμηλο detail Density
- Χρήση Gpu Instancing Σε κοινά Materials
- Έλεχγος της απόδοσης μέσω του Profiler
- Σημείωση των ακίνητων αντικειμένων ώς static
- Χρήση Απλών Shader
- Χρήση Baked Light   

### Κώδικας
> Για την κίνηση του χαρακτήρα χρησιμοποιείται το Move.cs και το Punched.cs το οποίο καλείται όταν γίνεται σύγκρουση μεταξύ των άκρων του χαρακτήρα και των εχθρών.
 Μέσα από αυτούς τους κώδικες αλλάζουν και τα animation σύμφωνα με τον παρακάτω animator
 ![Character Animator](image.jpg)
 >Για την κίνηση των εχθρών χρησιμοποιείται ο κώδικας BasicEnemy.cs και EnemyTerritory.cs.Το 2ο χρησιμοποιείται ώστε να ενεργοποιούνται οι έχθροι όταν ο παίκτης εισέλθει σε μια περιοχή.
  Ακομη Χρησιμοποιείται το Zpunch.cs οταν εχθρος χτυπά των παίκτη.
