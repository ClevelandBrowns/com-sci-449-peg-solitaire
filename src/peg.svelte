<main>
    <div class="grid">
        <div><button>1</button></div>
        <div><button>2</button></div>
        <div><button>3</button></div>
        <div><button>4</button></div>
        <div><button>5</button></div>
        <div><button>6</button></div>
        <div><button>7</button></div>
        <div><button>8</button></div>
        <div><div class="circle"></div></div>
    </div>
</main>

<style>
    button{
        border: 0;
        background-color: transparent;
        width: 50px;
        height: 50px;
    }

    .circle {
        background-color: black;
        border-radius: 10px;
        width: 10px;
        height: 10px;
    }

    .grid {
        display: grid;
        grid-template-columns: repeat(3, 50px);
        grid-template-rows: repeat(3, 50px);
        gap: 0;
    }

    .grid div {
        border: 1px solid black; /* visible gridlines */
        display: flex;
        align-items: center;
        justify-content: center;
        font-weight: bold;
    }
</style>