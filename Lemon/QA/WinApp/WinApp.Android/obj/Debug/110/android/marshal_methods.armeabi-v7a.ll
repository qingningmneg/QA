; ModuleID = 'obj\Debug\110\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\110\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [200 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 49
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 73
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 8
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 68
	i32 101534019, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 59
	i32 120558881, ; 5: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 59
	i32 165246403, ; 6: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 34
	i32 166922606, ; 7: Xamarin.Android.Support.Compat.dll => 0x9f3096e => 18
	i32 172012715, ; 8: FastAndroidCamera.dll => 0xa40b4ab => 3
	i32 182336117, ; 9: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 60
	i32 209399409, ; 10: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 32
	i32 219130465, ; 11: Xamarin.Android.Support.v4 => 0xd0faa61 => 23
	i32 220171995, ; 12: System.Diagnostics.Debug => 0xd1f8edb => 93
	i32 230216969, ; 13: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 44
	i32 231814094, ; 14: System.Globalization => 0xdd133ce => 99
	i32 232815796, ; 15: System.Web.Services => 0xde07cb4 => 88
	i32 278686392, ; 16: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 48
	i32 280482487, ; 17: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 42
	i32 318968648, ; 18: Xamarin.AndroidX.Activity.dll => 0x13031348 => 24
	i32 321597661, ; 19: System.Numerics => 0x132b30dd => 11
	i32 334355562, ; 20: ZXing.Net.Mobile.Forms.dll => 0x13eddc6a => 76
	i32 342366114, ; 21: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 46
	i32 368320334, ; 22: WinApp.Android => 0x15f41f4e => 0
	i32 389971796, ; 23: Xamarin.Android.Support.Core.UI => 0x173e7f54 => 19
	i32 442521989, ; 24: Xamarin.Essentials => 0x1a605985 => 67
	i32 442565967, ; 25: System.Collections => 0x1a61054f => 91
	i32 450948140, ; 26: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 41
	i32 465846621, ; 27: mscorlib => 0x1bc4415d => 7
	i32 469710990, ; 28: System.dll => 0x1bff388e => 10
	i32 476646585, ; 29: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 42
	i32 486930444, ; 30: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 53
	i32 498788369, ; 31: System.ObjectModel => 0x1dbae811 => 94
	i32 514659665, ; 32: Xamarin.Android.Support.Compat => 0x1ead1551 => 18
	i32 526420162, ; 33: System.Transactions.dll => 0x1f6088c2 => 83
	i32 545304856, ; 34: System.Runtime.Extensions => 0x2080b118 => 92
	i32 605376203, ; 35: System.IO.Compression.FileSystem => 0x24154ecb => 86
	i32 627609679, ; 36: Xamarin.AndroidX.CustomView => 0x2568904f => 38
	i32 663517072, ; 37: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 64
	i32 666292255, ; 38: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 29
	i32 690569205, ; 39: System.Xml.Linq.dll => 0x29293ff5 => 15
	i32 692692150, ; 40: Xamarin.Android.Support.Annotations => 0x2949a4b6 => 17
	i32 775507847, ; 41: System.IO.Compression => 0x2e394f87 => 85
	i32 809851609, ; 42: System.Drawing.Common.dll => 0x30455ad9 => 80
	i32 843511501, ; 43: Xamarin.AndroidX.Print => 0x3246f6cd => 56
	i32 877678880, ; 44: System.Globalization.dll => 0x34505120 => 99
	i32 882883187, ; 45: Xamarin.Android.Support.v4.dll => 0x349fba73 => 23
	i32 928116545, ; 46: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 73
	i32 954320159, ; 47: ZXing.Net.Mobile.Forms => 0x38e1c51f => 76
	i32 955402788, ; 48: Newtonsoft.Json => 0x38f24a24 => 8
	i32 958213972, ; 49: Xamarin.Android.Support.Media.Compat => 0x391d2f54 => 22
	i32 967690846, ; 50: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 46
	i32 974778368, ; 51: FormsViewGroup.dll => 0x3a19f000 => 4
	i32 992768348, ; 52: System.Collections.dll => 0x3b2c715c => 91
	i32 1012816738, ; 53: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 58
	i32 1035644815, ; 54: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 28
	i32 1042160112, ; 55: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 70
	i32 1052210849, ; 56: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 50
	i32 1098259244, ; 57: System => 0x41761b2c => 10
	i32 1134191450, ; 58: ZXingNetMobile.dll => 0x439a635a => 78
	i32 1175144683, ; 59: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 62
	i32 1204270330, ; 60: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 29
	i32 1267360935, ; 61: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 63
	i32 1293217323, ; 62: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 40
	i32 1364015309, ; 63: System.IO => 0x514d38cd => 97
	i32 1365406463, ; 64: System.ServiceModel.Internals.dll => 0x516272ff => 79
	i32 1376866003, ; 65: Xamarin.AndroidX.SavedState => 0x52114ed3 => 58
	i32 1395857551, ; 66: Xamarin.AndroidX.Media.dll => 0x5333188f => 54
	i32 1406073936, ; 67: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 35
	i32 1445445088, ; 68: Xamarin.Android.Support.Fragment => 0x5627bde0 => 21
	i32 1457743152, ; 69: System.Runtime.Extensions.dll => 0x56e36530 => 92
	i32 1460219004, ; 70: Xamarin.Forms.Xaml => 0x57092c7c => 71
	i32 1462112819, ; 71: System.IO.Compression.dll => 0x57261233 => 85
	i32 1469204771, ; 72: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 27
	i32 1543031311, ; 73: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 98
	i32 1571005899, ; 74: zxing.portable => 0x5da3a5cb => 77
	i32 1574652163, ; 75: Xamarin.Android.Support.Core.Utils.dll => 0x5ddb4903 => 20
	i32 1582372066, ; 76: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 39
	i32 1592978981, ; 77: System.Runtime.Serialization.dll => 0x5ef2ee25 => 2
	i32 1622152042, ; 78: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 52
	i32 1624863272, ; 79: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 66
	i32 1636350590, ; 80: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 37
	i32 1639515021, ; 81: System.Net.Http.dll => 0x61b9038d => 1
	i32 1639986890, ; 82: System.Text.RegularExpressions => 0x61c036ca => 98
	i32 1657153582, ; 83: System.Runtime => 0x62c6282e => 13
	i32 1658251792, ; 84: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 72
	i32 1701541528, ; 85: System.Diagnostics.Debug.dll => 0x656b7698 => 93
	i32 1729485958, ; 86: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 33
	i32 1766324549, ; 87: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 60
	i32 1776026572, ; 88: System.Core.dll => 0x69dc03cc => 9
	i32 1788241197, ; 89: Xamarin.AndroidX.Fragment => 0x6a96652d => 41
	i32 1808609942, ; 90: Xamarin.AndroidX.Loader => 0x6bcd3296 => 52
	i32 1813201214, ; 91: Xamarin.Google.Android.Material => 0x6c13413e => 72
	i32 1867746548, ; 92: Xamarin.Essentials.dll => 0x6f538cf4 => 67
	i32 1878053835, ; 93: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 71
	i32 1885316902, ; 94: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 30
	i32 1904184254, ; 95: FastAndroidCamera => 0x717f8bbe => 3
	i32 1919157823, ; 96: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 55
	i32 2019465201, ; 97: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 50
	i32 2055257422, ; 98: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 47
	i32 2079903147, ; 99: System.Runtime.dll => 0x7bf8cdab => 13
	i32 2090596640, ; 100: System.Numerics.Vectors => 0x7c9bf920 => 12
	i32 2097448633, ; 101: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 43
	i32 2126786730, ; 102: Xamarin.Forms.Platform.Android => 0x7ec430aa => 69
	i32 2166116741, ; 103: Xamarin.Android.Support.Core.Utils => 0x811c5185 => 20
	i32 2193016926, ; 104: System.ObjectModel.dll => 0x82b6c85e => 94
	i32 2201231467, ; 105: System.Net.Http => 0x8334206b => 1
	i32 2217644978, ; 106: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 62
	i32 2244775296, ; 107: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 53
	i32 2256548716, ; 108: Xamarin.AndroidX.MultiDex => 0x8680336c => 55
	i32 2261435625, ; 109: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 45
	i32 2279755925, ; 110: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 57
	i32 2315684594, ; 111: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 25
	i32 2329204181, ; 112: zxing.portable.dll => 0x8ad4d5d5 => 77
	i32 2330457430, ; 113: Xamarin.Android.Support.Core.UI.dll => 0x8ae7f556 => 19
	i32 2341995103, ; 114: ZXingNetMobile => 0x8b98025f => 78
	i32 2373288475, ; 115: Xamarin.Android.Support.Fragment.dll => 0x8d75821b => 21
	i32 2431243866, ; 116: ZXing.Net.Mobile.Core.dll => 0x90e9d65a => 74
	i32 2443909279, ; 117: WinApp.dll => 0x91ab189f => 16
	i32 2454642406, ; 118: System.Text.Encoding.dll => 0x924edee6 => 96
	i32 2471841756, ; 119: netstandard.dll => 0x93554fdc => 81
	i32 2475788418, ; 120: Java.Interop.dll => 0x93918882 => 5
	i32 2482213323, ; 121: ZXing.Net.Mobile.Forms.Android => 0x93f391cb => 75
	i32 2483657755, ; 122: WinApp.Android.dll => 0x94099c1b => 0
	i32 2501346920, ; 123: System.Data.DataSetExtensions => 0x95178668 => 84
	i32 2505896520, ; 124: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 49
	i32 2581819634, ; 125: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 63
	i32 2620871830, ; 126: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 37
	i32 2633051222, ; 127: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 48
	i32 2693849962, ; 128: System.IO.dll => 0xa090e36a => 97
	i32 2715334215, ; 129: System.Threading.Tasks.dll => 0xa1d8b647 => 90
	i32 2732626843, ; 130: Xamarin.AndroidX.Activity => 0xa2e0939b => 24
	i32 2737747696, ; 131: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 27
	i32 2766581644, ; 132: Xamarin.Forms.Core => 0xa4e6af8c => 68
	i32 2778768386, ; 133: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 65
	i32 2810250172, ; 134: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 35
	i32 2819470561, ; 135: System.Xml.dll => 0xa80db4e1 => 14
	i32 2853208004, ; 136: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 65
	i32 2855708567, ; 137: Xamarin.AndroidX.Transition => 0xaa36a797 => 61
	i32 2903344695, ; 138: System.ComponentModel.Composition => 0xad0d8637 => 87
	i32 2905242038, ; 139: mscorlib.dll => 0xad2a79b6 => 7
	i32 2916838712, ; 140: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 66
	i32 2919462931, ; 141: System.Numerics.Vectors.dll => 0xae037813 => 12
	i32 2921128767, ; 142: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 26
	i32 2978675010, ; 143: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 40
	i32 3024354802, ; 144: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 44
	i32 3044182254, ; 145: FormsViewGroup => 0xb57288ee => 4
	i32 3075834255, ; 146: System.Threading.Tasks => 0xb755818f => 90
	i32 3092211740, ; 147: Xamarin.Android.Support.Media.Compat.dll => 0xb84f681c => 22
	i32 3111772706, ; 148: System.Runtime.Serialization => 0xb979e222 => 2
	i32 3204380047, ; 149: System.Data.dll => 0xbefef58f => 82
	i32 3211777861, ; 150: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 39
	i32 3220365878, ; 151: System.Threading => 0xbff2e236 => 95
	i32 3247949154, ; 152: Mono.Security => 0xc197c562 => 89
	i32 3258312781, ; 153: Xamarin.AndroidX.CardView => 0xc235e84d => 33
	i32 3267021929, ; 154: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 31
	i32 3299363146, ; 155: System.Text.Encoding => 0xc4a8494a => 96
	i32 3317135071, ; 156: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 38
	i32 3317144872, ; 157: System.Data => 0xc5b79d28 => 82
	i32 3340431453, ; 158: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 30
	i32 3353484488, ; 159: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 43
	i32 3362522851, ; 160: Xamarin.AndroidX.Core => 0xc86c06e3 => 36
	i32 3366347497, ; 161: Java.Interop => 0xc8a662e9 => 5
	i32 3374999561, ; 162: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 57
	i32 3404865022, ; 163: System.ServiceModel.Internals => 0xcaf21dfe => 79
	i32 3429136800, ; 164: System.Xml => 0xcc6479a0 => 14
	i32 3430777524, ; 165: netstandard => 0xcc7d82b4 => 81
	i32 3439690031, ; 166: Xamarin.Android.Support.Annotations.dll => 0xcd05812f => 17
	i32 3471932268, ; 167: WinApp => 0xcef17b6c => 16
	i32 3476120550, ; 168: Mono.Android => 0xcf3163e6 => 6
	i32 3486566296, ; 169: System.Transactions => 0xcfd0c798 => 83
	i32 3501239056, ; 170: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 31
	i32 3509114376, ; 171: System.Xml.Linq => 0xd128d608 => 15
	i32 3536029504, ; 172: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 69
	i32 3567349600, ; 173: System.ComponentModel.Composition.dll => 0xd4a16f60 => 87
	i32 3627220390, ; 174: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 56
	i32 3632359727, ; 175: Xamarin.Forms.Platform => 0xd881692f => 70
	i32 3633644679, ; 176: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 26
	i32 3641597786, ; 177: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 47
	i32 3672681054, ; 178: Mono.Android.dll => 0xdae8aa5e => 6
	i32 3676310014, ; 179: System.Web.Services.dll => 0xdb2009fe => 88
	i32 3682565725, ; 180: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 32
	i32 3689375977, ; 181: System.Drawing.Common => 0xdbe768e9 => 80
	i32 3718780102, ; 182: Xamarin.AndroidX.Annotation => 0xdda814c6 => 25
	i32 3758932259, ; 183: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 45
	i32 3786282454, ; 184: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 34
	i32 3822602673, ; 185: Xamarin.AndroidX.Media => 0xe3d849b1 => 54
	i32 3829621856, ; 186: System.Numerics.dll => 0xe4436460 => 11
	i32 3847036339, ; 187: ZXing.Net.Mobile.Forms.Android.dll => 0xe54d1db3 => 75
	i32 3885922214, ; 188: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 61
	i32 3896760992, ; 189: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 36
	i32 3920810846, ; 190: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 86
	i32 3921031405, ; 191: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 64
	i32 3945713374, ; 192: System.Data.DataSetExtensions.dll => 0xeb2ecede => 84
	i32 3955647286, ; 193: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 28
	i32 4073602200, ; 194: System.Threading.dll => 0xf2ce3c98 => 95
	i32 4105002889, ; 195: Mono.Security.dll => 0xf4ad5f89 => 89
	i32 4151237749, ; 196: System.Core => 0xf76edc75 => 9
	i32 4182413190, ; 197: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 51
	i32 4186595366, ; 198: ZXing.Net.Mobile.Core => 0xf98a6026 => 74
	i32 4292120959 ; 199: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 51
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [200 x i32] [
	i32 49, i32 73, i32 8, i32 68, i32 59, i32 59, i32 34, i32 18, ; 0..7
	i32 3, i32 60, i32 32, i32 23, i32 93, i32 44, i32 99, i32 88, ; 8..15
	i32 48, i32 42, i32 24, i32 11, i32 76, i32 46, i32 0, i32 19, ; 16..23
	i32 67, i32 91, i32 41, i32 7, i32 10, i32 42, i32 53, i32 94, ; 24..31
	i32 18, i32 83, i32 92, i32 86, i32 38, i32 64, i32 29, i32 15, ; 32..39
	i32 17, i32 85, i32 80, i32 56, i32 99, i32 23, i32 73, i32 76, ; 40..47
	i32 8, i32 22, i32 46, i32 4, i32 91, i32 58, i32 28, i32 70, ; 48..55
	i32 50, i32 10, i32 78, i32 62, i32 29, i32 63, i32 40, i32 97, ; 56..63
	i32 79, i32 58, i32 54, i32 35, i32 21, i32 92, i32 71, i32 85, ; 64..71
	i32 27, i32 98, i32 77, i32 20, i32 39, i32 2, i32 52, i32 66, ; 72..79
	i32 37, i32 1, i32 98, i32 13, i32 72, i32 93, i32 33, i32 60, ; 80..87
	i32 9, i32 41, i32 52, i32 72, i32 67, i32 71, i32 30, i32 3, ; 88..95
	i32 55, i32 50, i32 47, i32 13, i32 12, i32 43, i32 69, i32 20, ; 96..103
	i32 94, i32 1, i32 62, i32 53, i32 55, i32 45, i32 57, i32 25, ; 104..111
	i32 77, i32 19, i32 78, i32 21, i32 74, i32 16, i32 96, i32 81, ; 112..119
	i32 5, i32 75, i32 0, i32 84, i32 49, i32 63, i32 37, i32 48, ; 120..127
	i32 97, i32 90, i32 24, i32 27, i32 68, i32 65, i32 35, i32 14, ; 128..135
	i32 65, i32 61, i32 87, i32 7, i32 66, i32 12, i32 26, i32 40, ; 136..143
	i32 44, i32 4, i32 90, i32 22, i32 2, i32 82, i32 39, i32 95, ; 144..151
	i32 89, i32 33, i32 31, i32 96, i32 38, i32 82, i32 30, i32 43, ; 152..159
	i32 36, i32 5, i32 57, i32 79, i32 14, i32 81, i32 17, i32 16, ; 160..167
	i32 6, i32 83, i32 31, i32 15, i32 69, i32 87, i32 56, i32 70, ; 168..175
	i32 26, i32 47, i32 6, i32 88, i32 32, i32 80, i32 25, i32 45, ; 176..183
	i32 34, i32 54, i32 11, i32 75, i32 61, i32 36, i32 86, i32 64, ; 184..191
	i32 84, i32 28, i32 95, i32 89, i32 9, i32 51, i32 74, i32 51 ; 200..199
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
