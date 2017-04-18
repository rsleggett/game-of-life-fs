module ``Describe Game Of Life``
    open NUnit.Framework
    open FsUnit

    [<TestFixture>]
    type ``Given a single tick occurred`` () =
        let gameOfLife = new GameOfLife()

        [<Test>] member x.
            ``when there are no living cells, no cells come to life`` () =
                gameOfLife.Evolve(new Set<Cell>())

    
