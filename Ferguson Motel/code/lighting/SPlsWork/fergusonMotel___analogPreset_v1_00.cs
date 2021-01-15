using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_FERGUSONMOTEL___ANALOGPRESET_V1_00
{
    public class UserModuleClass_FERGUSONMOTEL___ANALOGPRESET_V1_00 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SAVE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> RECALL;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> ANALOG_F;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> ANALOG;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> PRE1;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> PRE2;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> PRE3;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> PRE4;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> PRE5;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> PRE6;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> PRE7;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> PRE8;
        private void PARSEVAL (  SplusExecutionContext __context__, ushort I ) 
            { 
            ushort COUNT = 0;
            
            
            __context__.SourceCodeLine = 22;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)I);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 26;
                        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__1 = (ushort)32; 
                        int __FN_FORSTEP_VAL__1 = (int)1; 
                        for ( COUNT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (COUNT  >= __FN_FORSTART_VAL__1) && (COUNT  <= __FN_FOREND_VAL__1) ) : ( (COUNT  <= __FN_FORSTART_VAL__1) && (COUNT  >= __FN_FOREND_VAL__1) ) ; COUNT  += (ushort)__FN_FORSTEP_VAL__1) 
                            { 
                            __context__.SourceCodeLine = 28;
                            PRE1 [ COUNT]  .Value = (ushort) ( _SplusNVRAM.GIPRE[ I , COUNT ] ) ; 
                            __context__.SourceCodeLine = 26;
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 33;
                        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__2 = (ushort)32; 
                        int __FN_FORSTEP_VAL__2 = (int)1; 
                        for ( COUNT  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (COUNT  >= __FN_FORSTART_VAL__2) && (COUNT  <= __FN_FOREND_VAL__2) ) : ( (COUNT  <= __FN_FORSTART_VAL__2) && (COUNT  >= __FN_FOREND_VAL__2) ) ; COUNT  += (ushort)__FN_FORSTEP_VAL__2) 
                            { 
                            __context__.SourceCodeLine = 35;
                            PRE2 [ COUNT]  .Value = (ushort) ( _SplusNVRAM.GIPRE[ I , COUNT ] ) ; 
                            __context__.SourceCodeLine = 33;
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 40;
                        ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__3 = (ushort)32; 
                        int __FN_FORSTEP_VAL__3 = (int)1; 
                        for ( COUNT  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (COUNT  >= __FN_FORSTART_VAL__3) && (COUNT  <= __FN_FOREND_VAL__3) ) : ( (COUNT  <= __FN_FORSTART_VAL__3) && (COUNT  >= __FN_FOREND_VAL__3) ) ; COUNT  += (ushort)__FN_FORSTEP_VAL__3) 
                            { 
                            __context__.SourceCodeLine = 42;
                            PRE3 [ COUNT]  .Value = (ushort) ( _SplusNVRAM.GIPRE[ I , COUNT ] ) ; 
                            __context__.SourceCodeLine = 40;
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 47;
                        ushort __FN_FORSTART_VAL__4 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__4 = (ushort)32; 
                        int __FN_FORSTEP_VAL__4 = (int)1; 
                        for ( COUNT  = __FN_FORSTART_VAL__4; (__FN_FORSTEP_VAL__4 > 0)  ? ( (COUNT  >= __FN_FORSTART_VAL__4) && (COUNT  <= __FN_FOREND_VAL__4) ) : ( (COUNT  <= __FN_FORSTART_VAL__4) && (COUNT  >= __FN_FOREND_VAL__4) ) ; COUNT  += (ushort)__FN_FORSTEP_VAL__4) 
                            { 
                            __context__.SourceCodeLine = 49;
                            PRE4 [ COUNT]  .Value = (ushort) ( _SplusNVRAM.GIPRE[ I , COUNT ] ) ; 
                            __context__.SourceCodeLine = 47;
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 54;
                        ushort __FN_FORSTART_VAL__5 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__5 = (ushort)32; 
                        int __FN_FORSTEP_VAL__5 = (int)1; 
                        for ( COUNT  = __FN_FORSTART_VAL__5; (__FN_FORSTEP_VAL__5 > 0)  ? ( (COUNT  >= __FN_FORSTART_VAL__5) && (COUNT  <= __FN_FOREND_VAL__5) ) : ( (COUNT  <= __FN_FORSTART_VAL__5) && (COUNT  >= __FN_FOREND_VAL__5) ) ; COUNT  += (ushort)__FN_FORSTEP_VAL__5) 
                            { 
                            __context__.SourceCodeLine = 56;
                            PRE5 [ COUNT]  .Value = (ushort) ( _SplusNVRAM.GIPRE[ I , COUNT ] ) ; 
                            __context__.SourceCodeLine = 54;
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 61;
                        ushort __FN_FORSTART_VAL__6 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__6 = (ushort)32; 
                        int __FN_FORSTEP_VAL__6 = (int)1; 
                        for ( COUNT  = __FN_FORSTART_VAL__6; (__FN_FORSTEP_VAL__6 > 0)  ? ( (COUNT  >= __FN_FORSTART_VAL__6) && (COUNT  <= __FN_FOREND_VAL__6) ) : ( (COUNT  <= __FN_FORSTART_VAL__6) && (COUNT  >= __FN_FOREND_VAL__6) ) ; COUNT  += (ushort)__FN_FORSTEP_VAL__6) 
                            { 
                            __context__.SourceCodeLine = 63;
                            PRE6 [ COUNT]  .Value = (ushort) ( _SplusNVRAM.GIPRE[ I , COUNT ] ) ; 
                            __context__.SourceCodeLine = 61;
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 68;
                        ushort __FN_FORSTART_VAL__7 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__7 = (ushort)32; 
                        int __FN_FORSTEP_VAL__7 = (int)1; 
                        for ( COUNT  = __FN_FORSTART_VAL__7; (__FN_FORSTEP_VAL__7 > 0)  ? ( (COUNT  >= __FN_FORSTART_VAL__7) && (COUNT  <= __FN_FOREND_VAL__7) ) : ( (COUNT  <= __FN_FORSTART_VAL__7) && (COUNT  >= __FN_FOREND_VAL__7) ) ; COUNT  += (ushort)__FN_FORSTEP_VAL__7) 
                            { 
                            __context__.SourceCodeLine = 70;
                            PRE7 [ COUNT]  .Value = (ushort) ( _SplusNVRAM.GIPRE[ I , COUNT ] ) ; 
                            __context__.SourceCodeLine = 68;
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 75;
                        ushort __FN_FORSTART_VAL__8 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__8 = (ushort)32; 
                        int __FN_FORSTEP_VAL__8 = (int)1; 
                        for ( COUNT  = __FN_FORSTART_VAL__8; (__FN_FORSTEP_VAL__8 > 0)  ? ( (COUNT  >= __FN_FORSTART_VAL__8) && (COUNT  <= __FN_FOREND_VAL__8) ) : ( (COUNT  <= __FN_FORSTART_VAL__8) && (COUNT  >= __FN_FOREND_VAL__8) ) ; COUNT  += (ushort)__FN_FORSTEP_VAL__8) 
                            { 
                            __context__.SourceCodeLine = 77;
                            PRE8 [ COUNT]  .Value = (ushort) ( _SplusNVRAM.GIPRE[ I , COUNT ] ) ; 
                            __context__.SourceCodeLine = 75;
                            } 
                        
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void SAVEPRE (  SplusExecutionContext __context__, ushort I ) 
            { 
            ushort COUNT = 0;
            
            
            __context__.SourceCodeLine = 87;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)32; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( COUNT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (COUNT  >= __FN_FORSTART_VAL__1) && (COUNT  <= __FN_FOREND_VAL__1) ) : ( (COUNT  <= __FN_FORSTART_VAL__1) && (COUNT  >= __FN_FOREND_VAL__1) ) ; COUNT  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 89;
                _SplusNVRAM.GIPRE [ I , COUNT] = (ushort) ( ANALOG_F[ COUNT ] .UshortValue ) ; 
                __context__.SourceCodeLine = 87;
                } 
            
            __context__.SourceCodeLine = 92;
            PARSEVAL (  __context__ , (ushort)( I )) ; 
            
            }
            
        private void RECALLPRE (  SplusExecutionContext __context__, ushort I ) 
            { 
            ushort COUNT = 0;
            
            
            __context__.SourceCodeLine = 99;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)32; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( COUNT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (COUNT  >= __FN_FORSTART_VAL__1) && (COUNT  <= __FN_FOREND_VAL__1) ) : ( (COUNT  <= __FN_FORSTART_VAL__1) && (COUNT  >= __FN_FOREND_VAL__1) ) ; COUNT  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 101;
                ANALOG [ COUNT]  .Value = (ushort) ( _SplusNVRAM.GIPRE[ I , COUNT ] ) ; 
                __context__.SourceCodeLine = 99;
                } 
            
            
            }
            
        object SAVE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 108;
                I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 110;
                SAVEPRE (  __context__ , (ushort)( I )) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object RECALL_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 116;
            I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 118;
            RECALLPRE (  __context__ , (ushort)( I )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    ushort COUNT = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 125;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 127;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)8; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( COUNT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (COUNT  >= __FN_FORSTART_VAL__1) && (COUNT  <= __FN_FOREND_VAL__1) ) : ( (COUNT  <= __FN_FORSTART_VAL__1) && (COUNT  >= __FN_FOREND_VAL__1) ) ; COUNT  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 129;
            PARSEVAL (  __context__ , (ushort)( COUNT )) ; 
            __context__.SourceCodeLine = 127;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.GIPRE  = new ushort[ 9,33 ];
    
    SAVE = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        SAVE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SAVE__DigitalInput__ + i, SAVE__DigitalInput__, this );
        m_DigitalInputList.Add( SAVE__DigitalInput__ + i, SAVE[i+1] );
    }
    
    RECALL = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        RECALL[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( RECALL__DigitalInput__ + i, RECALL__DigitalInput__, this );
        m_DigitalInputList.Add( RECALL__DigitalInput__ + i, RECALL[i+1] );
    }
    
    ANALOG_F = new InOutArray<AnalogInput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        ANALOG_F[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( ANALOG_F__AnalogSerialInput__ + i, ANALOG_F__AnalogSerialInput__, this );
        m_AnalogInputList.Add( ANALOG_F__AnalogSerialInput__ + i, ANALOG_F[i+1] );
    }
    
    ANALOG = new InOutArray<AnalogOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        ANALOG[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( ANALOG__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( ANALOG__AnalogSerialOutput__ + i, ANALOG[i+1] );
    }
    
    PRE1 = new InOutArray<AnalogOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        PRE1[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( PRE1__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( PRE1__AnalogSerialOutput__ + i, PRE1[i+1] );
    }
    
    PRE2 = new InOutArray<AnalogOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        PRE2[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( PRE2__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( PRE2__AnalogSerialOutput__ + i, PRE2[i+1] );
    }
    
    PRE3 = new InOutArray<AnalogOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        PRE3[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( PRE3__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( PRE3__AnalogSerialOutput__ + i, PRE3[i+1] );
    }
    
    PRE4 = new InOutArray<AnalogOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        PRE4[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( PRE4__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( PRE4__AnalogSerialOutput__ + i, PRE4[i+1] );
    }
    
    PRE5 = new InOutArray<AnalogOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        PRE5[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( PRE5__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( PRE5__AnalogSerialOutput__ + i, PRE5[i+1] );
    }
    
    PRE6 = new InOutArray<AnalogOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        PRE6[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( PRE6__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( PRE6__AnalogSerialOutput__ + i, PRE6[i+1] );
    }
    
    PRE7 = new InOutArray<AnalogOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        PRE7[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( PRE7__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( PRE7__AnalogSerialOutput__ + i, PRE7[i+1] );
    }
    
    PRE8 = new InOutArray<AnalogOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        PRE8[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( PRE8__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( PRE8__AnalogSerialOutput__ + i, PRE8[i+1] );
    }
    
    
    for( uint i = 0; i < 8; i++ )
        SAVE[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_OnPush_0, true ) );
        
    for( uint i = 0; i < 8; i++ )
        RECALL[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALL_OnPush_1, true ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_FERGUSONMOTEL___ANALOGPRESET_V1_00 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SAVE__DigitalInput__ = 0;
const uint RECALL__DigitalInput__ = 8;
const uint ANALOG_F__AnalogSerialInput__ = 0;
const uint ANALOG__AnalogSerialOutput__ = 0;
const uint PRE1__AnalogSerialOutput__ = 32;
const uint PRE2__AnalogSerialOutput__ = 64;
const uint PRE3__AnalogSerialOutput__ = 96;
const uint PRE4__AnalogSerialOutput__ = 128;
const uint PRE5__AnalogSerialOutput__ = 160;
const uint PRE6__AnalogSerialOutput__ = 192;
const uint PRE7__AnalogSerialOutput__ = 224;
const uint PRE8__AnalogSerialOutput__ = 256;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort [,] GIPRE;
            
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
