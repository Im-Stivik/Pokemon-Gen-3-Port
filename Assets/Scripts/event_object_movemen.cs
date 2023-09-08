using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class event_object_movemen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Palette slots for overworld NPCs.
    // The same standard set of palettes for overworld objects are normally always loaded at the same
    // time while walking around the overworld. The only exceptions are the palettes for the player and
    // the "special" NPC, which can be swapped out. This also means that e.g. two "special" NPCs
    // with competing palettes cannot be properly loaded at the same time.
    enum PaletteSlot{
        PALSLOT_PLAYER,
        PALSLOT_PLAYER_REFLECTION,
        PALSLOT_NPC_1,
        PALSLOT_NPC_2,
        PALSLOT_NPC_3,
        PALSLOT_NPC_4,
        PALSLOT_NPC_1_REFLECTION,
        PALSLOT_NPC_2_REFLECTION,
        PALSLOT_NPC_3_REFLECTION,
        PALSLOT_NPC_4_REFLECTION,
        PALSLOT_NPC_SPECIAL,
        PALSLOT_NPC_SPECIAL_REFLECTION,
        OBJ_PALSLOT_COUNT
        // the remaining sprite palette slots (12-15) are used by field effects, the interface, etc.
    };

    enum SpinnerRunnerFollowPatterns //TODO: check if this enum can be used globally
    {
        RUNFOLLOW_ANY,
        RUNFOLLOW_NORTH_SOUTH,
        RUNFOLLOW_EAST_WEST,
        RUNFOLLOW_NORTH_WEST,
        RUNFOLLOW_NORTH_EAST,
        RUNFOLLOW_SOUTH_WEST,
        RUNFOLLOW_SOUTH_EAST,
        RUNFOLLOW_NORTH_SOUTH_WEST,
        RUNFOLLOW_NORTH_SOUTH_EAST,
        RUNFOLLOW_NORTH_EAST_WEST,
        RUNFOLLOW_SOUTH_EAST_WEST
    };

    //TODO: implement this
    // struct StepAnimTable
    // {
    //     const union AnimCmd *const *anims;
    //     ushort animPos[4];
    // };

    //TODO: implement this
    // #define GROUND_EFFECT_FLAG_TALL_GRASS_ON_SPAWN   (1 << 0)
    // #define GROUND_EFFECT_FLAG_TALL_GRASS_ON_MOVE    (1 << 1)
    // #define GROUND_EFFECT_FLAG_LONG_GRASS_ON_SPAWN   (1 << 2)
    // #define GROUND_EFFECT_FLAG_LONG_GRASS_ON_MOVE    (1 << 3)
    // #define GROUND_EFFECT_FLAG_ICE_REFLECTION        (1 << 4)
    // #define GROUND_EFFECT_FLAG_REFLECTION            (1 << 5)
    // #define GROUND_EFFECT_FLAG_SHALLOW_FLOWING_WATER (1 << 6)
    // #define GROUND_EFFECT_FLAG_SAND                  (1 << 7)
    // #define GROUND_EFFECT_FLAG_DEEP_SAND             (1 << 8)
    // #define GROUND_EFFECT_FLAG_RIPPLES               (1 << 9)
    // #define GROUND_EFFECT_FLAG_PUDDLE                (1 << 10)
    // #define GROUND_EFFECT_FLAG_SAND_PILE             (1 << 11)
    // #define GROUND_EFFECT_FLAG_LAND_IN_TALL_GRASS    (1 << 12)
    // #define GROUND_EFFECT_FLAG_LAND_IN_LONG_GRASS    (1 << 13)
    // #define GROUND_EFFECT_FLAG_LAND_IN_SHALLOW_WATER (1 << 14)
    // #define GROUND_EFFECT_FLAG_LAND_IN_DEEP_WATER    (1 << 15)
    // #define GROUND_EFFECT_FLAG_LAND_ON_NORMAL_GROUND (1 << 16)
    // #define GROUND_EFFECT_FLAG_SHORT_GRASS           (1 << 17)
    // #define GROUND_EFFECT_FLAG_HOT_SPRINGS           (1 << 18)
    // #define GROUND_EFFECT_FLAG_SEAWEED               (1 << 19)


    // //TODO: implement this
    // struct PairedPalettes
    // {
    //     u16 tag;
    //     const u16 *data;
    // };


    ushort GetObjectEventIdByLocalIdAndMap(ushort h1, ushort h2, ushort h3) //TODO: implement this
    {
        return 0;
    }
    bool TryGetObjectEventIdByLocalIdAndMap(ushort h1, ushort h2, ushort h3, out ushort h4) //TODO: implement this
    {
        h4 = 0;
        return false;
    }

    ushort GetObjectEventIdByXY(Vector2 xy/*changed from two s16 for x and y to Vector 2*/) //TODO: implement this
    {
        return 0;
    }

    void SetObjectEventDirection(object eventObject, ushort h){}//TODO: implement this and figure out what eventObject is
    void RemoveObjectEventByLocalIdAndMap(ushort localId, ushort mapNum, ushort mapGroup){}//TODO: implement this
    ushort GetBoulderRevealFlagByLocalIdAndMap(ushort localId, ushort mapNum, ushort mapGroup){return 0;}//TODO: implement this
    void LoadPlayerObjectReflectionPalette(ushort h1, ushort h2){}//TODO: implement this
    void LoadSpecialObjectReflectionPalette(ushort h1, ushort h2){}//TODO: implement this
    void TryMoveObjectEventToMapCoords(ushort h1, ushort h2, ushort h3, ushort h4, ushort h5){}//TODO: implement this
    void PatchObjectPalette(ushort h1, ushort h2){} //TODO: implement this
    void SpawnObjectEventsOnReturnToField(Vector2 position/*changed to Vector 2*/){} //TODO: implement this
    Vector2 GetMapCoordsFromSpritePos(Vector2 position/*changed to Vector 2*/){return new Vector2();} //TODO: implement this
    ushort GetFaceDirectionAnimNum(ushort num){return 0;}//TODO: implement this
    void SetSpritePosToOffsetMapCoords(Vector2 position/*changed to Vector 2*/){} //TODO: implement this
    void ObjectEventClearHeldMovement(object eventObject){} //TODO: implement this and figure out what eventObject is
    void ObjectEventClearHeldMovementIfActive(object eventObject){} //TODO: implement this and figure out what eventObject is
    ushort CreateVirtualObject(ushort graphicsId, ushort virtualObjId, ushort x, ushort y, ushort elevation, ushort direction){return 0;}//TODO: implement this
    ushort CreateObjectGraphicsSprite(ushort graphicsId, Sprite callback, ushort x, ushort y, ushort subpriority){return 0;} //TODO: implement this
    ushort TrySpawnObjectEvent(ushort localId, ushort mapNum, ushort mapGroup){return 0;} //TODO: implement this
    int SpawnSpecialObjectEventParameterized(ushort h1, ushort h2, ushort h3, ushort h4, ushort h5, ushort h6){return 0;} //TODO: implement this
    ushort SpawnSpecialObjectEvent(object eventObject){return 0;} //TODO: implement this and figure out what eventObject is
    void CameraObjectReset1(){} //TODO: implement this
    void CameraObjectReset2(){} //TODO: implement this
    void ObjectEventSetGraphicsId(object eventObject, ushort h1){} //TODO: implement this and figure out what eventObject is
    void ObjectEventTurn(object eventObject, ushort h1){} //TODO: implement this and figure out what eventObject is
    void ObjectEventTurnByLocalIdAndMap(ushort h1, ushort h2, ushort h3, ushort h4){} //TODO: implement this
    void ObjectEventForceSetHeldMovement(object eventObject, ushort h1){} //TODO: implement this and figure out what eventObject is
    object GetObjectEventGraphicsInfo(ushort h) //TODO:implement this and figure out what ObjectEventGraphicsInfo is
    {
        return null;
    }
    void SetObjectInvisibility(ushort localId, ushort mapNum, ushort mapGroup, ushort state){} //TODO: implement this
    void FreeAndReserveObjectSpritePalettes(){} //TODO: implement this
    void SetObjectPositionByLocalIdAndMap(ushort localId, ushort mapNum, ushort mapGroup, Vector2 position/*changed to Vector 2*/){} //TODO: implement this
    void ResetObjectSubpriority(ushort localId, ushort mapNum, ushort mapGroup){} //TODO: implement this
    void SetObjectSubpriority(ushort localId, ushort mapNum, ushort mapGroup, ushort subpriority){} //TODO: implement this
    void ObjectEventGetLocalIdAndMap(object objectEvent, ushort localId, ushort mapNum, ushort mapGroup){} //TODO: implement this and figure out what objectEvent is
    void ShiftObjectEventCoords(object eventObject, ushort h1, ushort h2){} //TODO: implement this and figure out what eventObject is
    void TryOverrideObjectEventTemplateCoords(ushort h1, ushort h2, ushort h3){} //TODO: implement this
    void UpdateObjectEventCurrentMovement(){} //TODO: implement this and figure out what the function is getting
    ushort ObjectEventFaceOppositeDirection(object eventObject, ushort h1){return 0;} //TODO: implement this and figure out what eventObject is
    ushort GetOppositeDirection(ushort h){return 0;} //TODO: implement this
    ushort GetWalkInPlaceFasterMovementAction(ushort h){return 0;} //TODO: implement this
    ushort GetStepInPlaceDelay8AnimId(ushort h){return 0;} //TODO: implement this
    ushort GetWalkInPlaceNormalMovementAction(short u){return 0;} //TODO: implement this
    ushort GetWalkInPlaceSlowMovementAction(ushort h){return 0;} //TODO: implement this
    ushort GetWalkInPlaceFastMovementAction(ushort h){return 0;} //TODO: implement this
    ushort GetCollisionAtCoords(object eventObject, ushort h1, ushort h2, ushort h3){return 0;} //TODO: implement this and figure out what eventObject is
    void MoveCoords(ushort h1, ushort h2, ushort h3){} //TODO: implement this
    bool ObjectEventIsHeldMovementActive(object eventObject){return false;} //TODO: implement this and figure out what eventObject is
    ushort ObjectEventClearHeldMovementIfFinished(object eventObject){return 0;} //TODO: implement this and figure out what eventObject is
    ushort GetObjectEventIdByPosition(Vector2 position, ushort elevation /*changed to Vector 2*/){return 0;} //TODO: implement this
    void QL_UpdateObjectEventCurrentMovement(object eventObject, Sprite sprite){} //TODO: implement this and figure out what eventObject is
    void ObjectEventSetHeldMovement(object eventObject, ushort h1){} //TODO: implement this and figure out what eventObject is
    void ShiftStillObjectEventCoords(object eventObject, ushort h1){} //TODO: implement this and figure out what eventObject is
    void SetTrainerMovementType(object eventObject, ushort h1){} //TODO: implement this and figure out what eventObject is
    ushort GetFishingDirectionAnimNum(ushort direction){return 0;} //TODO: implement this
    ushort GetFishingNoCatchDirectionAnimNum(ushort a0){return 0;} //TODO: implement this
    // void ObjectEventSetGraphicsId(object eventObject, ushort a1){} //TODO: check why two identical functions exist
    ushort CreateFameCheckerObject(ushort graphicsId, ushort localId, Vector2 xy){return 0;} //TODO: implement this
    void InitObjectEventPalettes(ushort mode){} //TODO: implement this
    bool ObjectEventIsMovementOverridden(object eventObject){return false;} //TODO: implement this and figure out what eventObject is
    ushort ObjectEventCheckHeldMovementStatus(object eventObject){return 0;} //TODO: implement this and figure out what eventObject is
    ushort GetWalkNormalMovementAction(ushort h){return 0;} //TODO: implement this
    ushort GetWalkFastMovementAction(ushort h){return 0;} //TODO: implement this
    ushort GetWalkFasterMovementAction(ushort h){return 0;} //TODO: implement this
    ushort GetWalkSlowerMovementAction(ushort direction){return 0;} //TODO: implement this
    ushort GetTrainerFacingDirectionMovementType(ushort direction){return 0;} //TODO: implement this
    ushort GetFaceDirectionMovementAction(ushort direction){return 0;} //TODO: implement this
    ushort GetFaceDirectionFastMovementAction(ushort direction){return 0;} //TODO: implement this
    void CameraObjectSetFollowedObjectId(ushort objectId){} //TODO: implement this
    void UnfreezeObjectEvents() {}
    ushort GetSlideMovementAction(ushort h){return 0;} //TODO: implement this
    ushort GetJumpInPlaceMovementAction(ushort h){return 0;} //TODO: implement this
    ushort GetJumpMovementAction(ushort h){return 0;} //TODO: implement this
    ushort GetJump2MovementAction(ushort h){return 0;} //TODO: implement this
    bool UpdateWalkSlowerAnim(Sprite sprite){return false;} //TODO: implement this
    void SetJumpSpriteData(Sprite sprite, ushort h1, ushort h2, ushort h3) {} //TODO: implement this
    ushort DoJumpSpriteMovement(Sprite sprite){return 0;} //TODO: implement this
    ushort DoJumpSpecialSpriteMovement(Sprite sprite) { return 0; } //TODO: implement this
    void TurnVirtualObject(ushort virtualObjId, ushort direction) {} //TODO: implement this
    ushort GetObjectEventScriptPointerByObjectEventId(object objectEventId){return 0;} //TODO: implement this
    ushort GetFirstInactiveObjectEventId() { return 0; }//TODO: implement this
    ushort GetCollisionFlagsAtCoords(object objectEvent,Vector2 xy, ushort direction){return 0;} //TODO: implement this and figure out what objectEvent is
    void OverrideTemplateCoordsForObjectEvent(object objectEvent){} //TODO: implement this and figure out what objectEvent is
    void CancelPlayerForcedMovement() {} //TODO: implement this
    void FreezeObjectEvents(){} //TODO: implement this
    bool FreezeObjectEvent(object ObjectEvent){return false;} //TODO: implement this and figure out what ObjectEvent is
    void UnfreezeObjectEvent(object ObjectEvent ){} //TODO: implement this and figure out what ObjectEvent is
    void FreezeObjectEventsExceptOne(ushort objEventId){} //TODO: implement this
    void SetVirtualObjectGraphics(ushort virtualObjId, ushort direction){}
    void SetVirtualObjectInvisibility(ushort virtualObjId, bool invisible){}
    bool IsVirtualObjectInvisible(ushort virtualObjId){return false;}
    void SetVirtualObjectSpriteAnim(ushort virtualObjId, ushort animNo){}
    bool IsVirtualObjectAnimating(ushort virtualObjId){return false;}
    ushort GetJumpSpecialMovementAction(ushort direction){return 0;}
    void EnableObjectGroundEffectsByXY(Vector2 xy){} //TODO: implement this);
    void MoveObjectEventToMapCoords(object objectEvent, Vector2 xy){} //TODO: implement this and figure out what objectEvent is);
    ushort CreateCopySpriteAt(Sprite sprite, Vector2 xy, ushort subpriority){return 0;} //TODO: implement this);
    ushort GetObjectPaletteTag(ushort paletteIndex) {return 0;}
    void SetSpritePosToMapCoords(Vector2 xy, Vector2 xy2){}
    void UpdateObjectEventSpriteInvisibility(Sprite sprite, bool invisible){}
    ushort ElevationToPriority(ushort elevation){return 0;}
    void ObjectEventUpdateElevation(object pObject){}
    void SetObjectSubpriorityByElevation(ushort elevation, Sprite sprite, ushort offset){}
    //void CopyObjectGraphicsInfoToSpriteTemplate(ushort graphicsId, void (*callback)(struct Sprite *), struct SpriteTemplate *spriteTemplate, const struct SubspriteTable **subspriteTables);
    ushort AddCameraObject(ushort trackedSpriteId){return 0;}
    void UpdateObjectEventsForCameraUpdate(Vector2 xy){} //TODO: implement this);
    void SpriteCB_VirtualObject(Sprite sprite){}
    void SetMovementDelay(Sprite sprite, ushort h){}
    bool WaitForMovementDelay(Sprite sprite){return false;}
    void SetSpriteDataForNormalStep(Sprite sprite, ushort h1, ushort h2){}
    bool NpcTakeStep(Sprite sprite){return false;}
    void SetWalkSlowerSpriteData(Sprite sprite, ushort h){}
    void SetWalkSlowestSpriteData(Sprite sprite, ushort h){}
    bool UpdateWalkSlowestAnim(Sprite sprite){return false;}
    void SetWalkSlowSpriteData(Sprite sprite, ushort h){}
    bool UpdateWalkSlowAnim(Sprite sprite){return false;}
    void DoShadowFieldEffect(object eventObject){}
    void SetRunSlowSpriteData(Sprite sprite, ushort h){}
    bool UpdateRunSlowAnim(Sprite sprite){return false;}
    void SetAndStartSpriteAnim(Sprite sprite, ushort h1, ushort h2){}
    bool SpriteAnimEnded(Sprite sprite){return false;}
    ushort ObjectEventGetHeldMovementActionId(object objectEvent){return 0;}
    ushort GetMoveDirectionAnimNum(ushort direction){return 0;}

    // Exported data declarations

    // extern const struct SpriteTemplate *const gFieldEffectObjectTemplatePointers[];
    // extern const struct SpritePalette gSpritePalette_GeneralFieldEffect1;
    // extern const struct SpriteTemplate * const gFieldEffectObjectTemplatePointers[];
    // extern const struct OamData gObjectEventBaseOam_32x32;
    // extern const u16 gFieldEffectObjectPic_CutGrass[];
    // extern const u16 gFieldEffectPal_CutGrass[];
    // extern const u8 gReflectionEffectPaletteMap[];
    // u8 GetLedgeJumpDirection(s16 x, s16 y, u8 direction);
    // u8 GetGlideMovementAction(u32 direction);
    // u8 GetRideWaterCurrentMovementAction(u32 direction);
    // u8 GetPlayerRunMovementAction(u32 direction);
    // u8 GetPlayerRunSlowMovementAction(u32 direction);
    // u8 GetWalkSlowMovementAction(u32 direction);
    // u8 GetSpinMovementAction(u32 direction);
    // u8 GetAcroWheelieFaceDirectionMovementAction(u32 direction);
    // u8 GetAcroPopWheelieFaceDirectionMovementAction(u32 direction);
    // u8 GetAcroEndWheelieFaceDirectionMovementAction(u32 direction);
    // u8 GetAcroWheelieHopFaceDirectionMovementAction(u32 direction);
    // u8 GetAcroWheelieHopMovementAction(u32 direction);
    // u8 GetAcroPopWheelieMoveMovementAction(u32 direction);
    // u8 GetAcroWheelieJumpMovementAction(u32 direction);
    // u8 GetJumpInPlaceTurnAroundMovementAction(u32 direction);
    // u8 GetAcroWheelieInPlaceMovementAction(u32 direction);
    // u8 GetAcroPopWheelieMoveMovementAction(u32 direction);
    // u8 GetAcroWheelieMoveMovementAction(u32 direction);
    // u8 GetJumpSpecialWithEffectMovementAction(u32 direction);
    // u8 GetFishingBiteDirectionAnimNum(u8 direction);
    // void TrySpawnObjectEvents(s16 cameraX, s16 cameraY);
    //void ResetObjectEvents(void)

}
