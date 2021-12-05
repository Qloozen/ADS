class GameNode
{
    private int Marbels;
    private bool PlayerATurn;
    private GameNode LeftChild;
    private GameNode RightChild;
    public GameNode(int marbels, bool playerATurn)
    {
        this.Marbels = marbels;
        this.PlayerATurn = playerATurn;
        CreateTree();
    }

    public void CreateTree () {
        if (Marbels - 3 > 0) {
            LeftChild = new GameNode(Marbels - 3 , !PlayerATurn);
            LeftChild.CreateTree();
        }
        if(Marbels -1 > 0) {
            RightChild = new GameNode(Marbels -1, !PlayerATurn);
            RightChild.CreateTree();
        }
    }

    public int CountPlayerWins(bool playerA) {
        return CalculateWins(playerA);
    }

    public int CalculateWins(bool playerA) {
        //base case
        if(LeftChild == null && RightChild == null) {
            if(PlayerATurn) {
                return 0;
            } else {
                return 2;
            }
        }
        if (LeftChild == null || RightChild == null) {
            if (!PlayerATurn) {
                return 1;
            } else {
                return 0;
            }
        }

        return LeftChild.CalculateWins(playerA) + RightChild.CalculateWins(playerA);

    }
    
}