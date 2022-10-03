using UnityEngine;

public class Scene3_Puzzle : DialogNode
{
    [SerializeField]
    private DialogNode successPuzzleDialog;
    [SerializeField]
    private DialogNode failedPuzzleDialog;
    [SerializeField]
    private PuzzleFindRecipeIngredientsPackage puzzlePackage;

    public override void StartDialog()
    {
        PuzzleFindRecipeIngredientsPackage puzzleFindRecipeIngredientsPackage
            = new PuzzleFindRecipeIngredientsPackage(puzzlePackage.RecipeDifficulty,
                puzzlePackage.IngredientsCount, successPuzzleDialog);
        DialogOperator.SwithToPuzzle(puzzleFindRecipeIngredientsPackage);
    }
}
