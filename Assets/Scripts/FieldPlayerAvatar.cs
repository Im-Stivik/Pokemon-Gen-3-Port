using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldPlayerAvatar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void ClearPlayerAvatarInfo(){}//TODO: implement

    void SetPlayerAvatarExtraStateTransition(ushort h1, ushort h2){}//TODO: implement

    ushort GetPlayerAvatarGenderByGraphicsId(ushort h){//TODO: implement
        return 0;
    }
    Vector2 PlayerGetDestCoords(){ //changed the pointer of two values to return a vector2
        return new Vector2(0,0);
    }//TODO: implement

    void GetPlayerMovementDirection(){}//TODO: implement

    void MovePlayerNotOnBike(Vector2 directions, ushort heldKeys){} //changed the u8 directions to a vector2
    //TODO: implement

    void MovementType_Player(Sprite sprite){}//TODO: implement

    void HandleEnforcedLookDirectionOnPlayerStopMoving(){}//TODO: implement
    void StopPlayerAvatar(){}//TODO: implement
    Vector2 GetXYCoordsOneStepInFrontOfPlayer(){ //changed the pointer of two values to return a vector2
        return new Vector2(0,0);
    }//TODO: implement
    ushort GetPlayerAvatarGraphicsIdByStateId(ushort h){
        return 0;
    }//TODO: implement
    void SetPlayerAvatarStateMask(ushort mask){}//TODO: implement
    void AlignFishingAnimationFrames(Sprite sprite){}//TODO: implement

    void CreateStopSurfingTask_NoMusicChange(Vector2 direction){} //changed the u8 direction to a vector2
    //TODO: implement
    void SavePlayerFacingDirectionForTeleport(Vector2 direction){} //changed the u8 direction to a vector2
    //TODO: implement
    void SetPlayerAvatarTransitionFlags(ushort flags){}//TODO: implement
    bool IsPlayerFacingSurfableFishableWater(){return false;}//TODO: implement
    void startFishing(ushort secondaryId){}//TODO: implement
    ushort GetPlayerAvatarObjectId(){return 0;} //TODO: implement
    ushort PlayerGetElevation(){return 0;}//TODO: implement
    ushort GetPlayerAvatarGraphicsIdByCurrentState(){return 0;}//TODO: implement
    void StartPlayerAvatarSummonMonForFieldMoveAnim(){}//TODO: implement
    void SetPlayerInvisibility(bool invisible){}//TODO: implement
    void StartTeleportInPlayerAnim(){}//TODO: implement
    void StartTeleportWarpOutPlayerAnim(){}//TODO: implement
    bool WaitTeleportWarpOutPlayerAnim(){return false;}//TODO: implement
    bool WaitTeleportInPlayerAnim(){return false;}//TODO: implement
    bool PartyHasMonWithSurf(){return false;}//TODO: implement
    bool IsPlayerSurfingNorth(){return false;}//TODO: implement
    Vector2 player_get_pos_including_state_based_drift(){return new Vector2(0,0);}//TODO: check how to overcome the pointers in the right way
    //TODO: implement
    void StartPlayerAvatarVsSeekerAnim(){}//TODO: implement
    ushort GetRivalAvatarGraphicsIdByStateIdAndGender(ushort state, ushort gender){return 0;}//TODO: implement
    ushort GetPlayerAvatarGraphicsIdByStateIdAndGender(ushort state, ushort gender){return 0;}//TODO: implement
    ushort CheckForObjectEventCollision(){return 0;} //TODO: implemet in the unity way
    void PlayerWalkSlower(ushort direction){}//TODO: implement
    void PlayerWalkSlow(ushort direction){}//TODO: implement
    void PlayerWalkNormal(ushort direction){}//TODO: implement
    void PlayerWalkFast(ushort direction){}//TODO: implement
    void PlayerGlide(ushort direction){}//TODO: implement
    void PlayerRideWaterCurrent(ushort direction){}//TODO: implement
    void PlayerWalkFaster(ushort direction){}//TODO: implement
    void PlayerRun(ushort direction){}//TODO: implement
    void PlayerRunSlow(ushort direction){}//TODO: implement
    void PlayerOnBikeCollide(ushort direction){}//TODO: implement
    void PlayerNotOnBikeCollide(ushort direction){}//TODO: implement
    void PlayerFaceDirection(ushort direction){}//TODO: implement
    void PlayerFaceDirectionFast(ushort direction){}//TODO: implement
    void PlayerTurnInPlace(ushort direction){}//TODO: implement
    void PlayerJumpLedge(ushort direction){}//TODO: implement
    void PlayerShakeHeadOrWalkInPlace(ushort direction){}//TODO: implement
    void player_step(ushort direction, ushort newKeys, ushort heldKeys){}//TODO: implement
    bool PlayerIsMovingOnRockStairs(ushort direction){return false;}//TODO: implement
    void UpdatePlayerAvatarTransitionState(){}//TODO: implement
    void InitPlayerAvatar(Vector2 position, Vector2 direction, ushort gender){}//changed the direction and position to vector2
    //TODO: implement
    void PlayerUseAcroBikeOnBumpySlope(ushort direction){}//TODO: implement
    ushort GetRSAvatarGraphicsIdByGender(ushort gender){return 0;}//TODO: implement
}
