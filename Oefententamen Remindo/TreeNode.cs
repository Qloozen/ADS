using System;
class TreeNode {
	int value;
	TreeNode leftChild;
	TreeNode rightChild;

	public TreeNode(int value, TreeNode leftChild, TreeNode rightChild) {
		this.value = value;
		this.leftChild = leftChild;
		this.rightChild = rightChild;
	}


	// Naamgeving is in C# standaard
	public int SpecialSum() {
		int counter = 0;
		return calculate(ref counter);
	}
	public int calculate(ref int counter) {
		//Base Case, leaf node
		if(leftChild == null && rightChild == null) {
			return 0;
		}

		counter ++;

		//Current node and right sub-tree
		if(leftChild == null && rightChild != null) {
			return this.value * counter + rightChild.calculate(ref counter);
		}

		//Current node and Left sub-tree
		if(leftChild != null && rightChild == null) {
			return this.value * counter + leftChild.calculate(ref counter);
		}

		//Current node, left and right sub-tree
		return this.value * counter + leftChild.calculate(ref counter) + rightChild.calculate(ref counter);
	}
}
