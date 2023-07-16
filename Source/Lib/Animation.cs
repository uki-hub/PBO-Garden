using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO.Source.Lib
{
    static class Script
    {
        public static string lottiePlayer = Properties.Resources.lottie_player;

    }

    static class Lottie
    {
        public static string Water = Properties.Resources.water;
        public static string Bag = Properties.Resources.bag;
        public static string Shovel = Properties.Resources.shovel;
        public static string Shiny = Properties.Resources.shiny;
        public static string Plant0 = Properties.Resources.plant_0;
        public static string Plant1 = Properties.Resources.plant_1;
        public static string Plant2 = Properties.Resources.plant_2;
        public static string Plant3 = Properties.Resources.plant_3;
    }

    internal class Animation
    {
        public static string Plant(int posisi, int maxAir, int maxPupuk, string base64Image)
        {

            return $@"
<head>
    <style>
        * {{
            -moz-user-select: none;
            -khtml-user-select: none;
            -webkit-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }}

        #wrapper {{
            width: 150px;
            height: 150px;
            position: relative;
            overflow: hidden;
        }}

        #status {{
            text-align: center;
            font: 800 20px Arial;
            -webkit-text-fill-color: transparent;
            -webkit-text-stroke: 1px;
        }}

        #shovel {{
            position: absolute;
            top: -8px;
            left: -5px;
            width: 150px;
            height: 150px;
        }}

        #plant {{
            position: absolute;
            top: -50px;
            left: -25px;
            width: 200px;
            height: 200px;
        }}

        #water {{
            position: absolute;
            top: -100px;
            left: -40px;
            width: 300px;
            height: 300px;
        }}

        #bag {{
            visibility: hidden;
            position: absolute;
            top: -40px;
            left: -30px;
            width: 200px;
            height: 200px; 
        }}

        #flower {{
            visibility: hidden;
            background-image: url('data:image/png;base64, {base64Image}');
            object-fit: cover;
            position: absolute;
            width: 100%;
            height: 100%;
            z-index: 998;
            background-repeat: no-repeat;
        }}

        #shiny {{
            visibility: hidden;
            position: absolute;
            width: 100%;
            height: 100%;
            z-index: 999;
        }}

        .siram {{
            cursor: url('data:image/png;base64, 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'), auto;
        }}

        .pupuk {{
            cursor: url('data:image/png;base64, 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'), auto;
        }}

        .petik {{
            cursor: url('data:image/png;base64, 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'), auto;
        }}

        .cabut {{
            cursor: url('data:image/png;base64, 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'), auto;
        }}
    </style>
    <script>{Script.lottiePlayer}</script>
</head>
<body>
    <div id='wrapper'>
        <div id='status'></div>
        <lottie-player id='shovel' background='transparent'  speed='1' autoplay></lottie-player>
        <lottie-player id='plant' background='transparent' speed='1' autoplay></lottie-player>
        <lottie-player id='water' background='transparent' speed='1'></lottie-player>
        <lottie-player id='bag' background='transparent' speed='1'></lottie-player>
        <lottie-player id='shiny' background='transparent' speed='2' autoplay loop></lottie-player>
        <div id='flower'></div>
    </div>
</body>
<script>    
    const $id = (i) => document.getElementById(i);
    const $p = (p) => window.chrome.webview.postMessage(p);

    const state = {{
        air: 0,
        _air: {maxAir},
        pupuk: 0,
        _pupuk: {maxPupuk}
    }};

    const statusLabel = $id('status')
    const shovel = $id('shovel');
    const plant = $id('plant');
    const water = $id('water');
    const bag = $id('bag');
    const flower = $id('flower');
    const shiny = $id('shiny');
    var mode;
    var isAnimateDone;

    const createPayload = (payload) => (JSON.stringify({{
            posisi: {posisi},
            ...(payload ?? {{}})
        }}));

    const waitForAnimated = async () => {{
        while(!isAnimateDone) await (new Promise(resolve => setTimeout(resolve, 50))); 
        
        isAnimateDone = null;
    }}

    const updateState = (m) => {{
        const _s = state[m] + 1;
        state[m] = _s;
        updateStatus();
    }}

    const resetState = () => {{
        state['air'] = 0;
        state['pupuk'] = 0;
        updateStatus();
    }}

    const setMode = (m) => {{
        if(mode == 'petik') return;

        document.body.className = (m);
        mode = m;
    }}

    const updateStatus = () => statusLabel.innerText = `🔵${{state['air']}}/${{state['_air']}} 🟤${{state['pupuk']}}/${{state['_pupuk']}}`;

    const setPlant = async (p) => {{
        plant.load(p);
        resetState();
    }}

    const siram = () => {{
        if(!water.seeker || water.seeker == 0) water.play();
        else water.seek(0);

        waitForAnimated();

        updateState('air');        
        $p(createPayload({{'action': 'siram'}}));
    }}

    const pupuk = () => {{
        bag.style.visibility = 'visible';

        if(!bag.seeker || bag.seeker == 0) bag.play();
        else bag.seek(0);

        waitForAnimated();

        updateState('pupuk');
        $p(createPayload({{'action': 'pupuk'}}));
    }}

    const bunga = () => {{
        flower.style.visibility = 'visible';
        shiny.style.visibility = 'visible';
        shovel.remove();
        plant.remove();
        water.remove();
        bag.remove();

        setMode('petik');
    }}

    const petik = () => {{
        //waitForAnimated();

        $p(createPayload({{'action': 'petik'}}));
    }}

    const cabut = () => {{
        if(!shovel.seeker || shovel.seeker == 0) shovel.play();
        else shovel.seek(0);

        waitForAnimated();

        $p(createPayload({{'action': 'cabut'}}));
    }}

    (() => {{
        shovel.load({Lottie.Shovel});
        plant.load({Lottie.Plant0});
        water.load({Lottie.Water});
        bag.load({Lottie.Bag});
        shiny.load({Lottie.Shiny});

        shovel.addEventListener('complete', () => (isAnimateDone = isAnimateDone == false ? true : null));
        plant.addEventListener('complete', () => (isAnimateDone = isAnimateDone == false ? true : null));
        water.addEventListener('complete', () => (isAnimateDone = isAnimateDone == false ? true : null));
        bag.addEventListener('complete', () => {{
            bag.style.visibility = 'hidden';
            isAnimateDone = isAnimateDone == false ? true : null;
        }});

        isAnimateDone = null;
        resetState();
        setMode('siram');
    }})();

    document.body.onclick = () => {{
        if(mode == 'petik') {{
            petik();
            return;
        }}

        if(isAnimateDone == null) {{
            isAnimateDone = false;
            eval(mode)();
        }}
    }};
</script>
";
        }
    }
}
