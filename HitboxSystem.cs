using Godot;
using Interfaces;

[GlobalClass, Tool]
public sealed partial class HitboxSystem : Area3D
{
    public IDamagable idamagable;
    [Export] NodePath idamagable_path;
    [Export] public Skeleton3D skeleton;

    #region Body Parts

    [ExportGroup("Head")]
    [Export] public int head_bone_index;
    [Export] public CollisionShape3D head_collider;

    [Export]
    public Vector3
        head_default_position,
        head_default_rotation_degrees;

    [ExportGroup("Upper Body")]

    [Export] public int upper_body_bone_index;
    [Export] public CollisionShape3D upper_body_collider;

    [Export]
    public Vector3
    upper_body_default_position,
    upper_body_default_rotation_degrees;

    [ExportGroup("Lower Body")]

    [Export] public int lower_body_bone_index;
    [Export] public CollisionShape3D lower_body_collider;

    [Export]
    public Vector3
    lower_body_default_position,
    lower_body_default_rotation_degrees;

    [ExportGroup("Left Upper Arm")]
    [Export] public int left_upper_arm_bone_index;
    [Export] public CollisionShape3D left_upper_arm_collider;

    [Export]
    public Vector3
        left_upper_arm_default_position,
        left_upper_arm_default_rotation_degrees;

    [ExportGroup("Left Lower Arm")]
    [Export] public int left_lower_arm_bone_index;
    [Export] public CollisionShape3D left_lower_arm_collider;

    [Export]
    public Vector3
        left_lower_arm_default_position,
        left_lower_arm_default_rotation_degrees;

    [ExportGroup("Right Upper Arm")]
    [Export] public int right_upper_arm_bone_index;
    [Export] public CollisionShape3D right_upper_arm_collider;

    [Export]
    public Vector3
        right_upper_arm_default_position,
        right_upper_arm_default_rotation_degrees;

    [ExportGroup("Right Lower Arm")]
    [Export] public int right_lower_arm_bone_index;
    [Export] public CollisionShape3D right_lower_arm_collider;

    [Export]
    public Vector3
        right_lower_arm_default_position,
        right_lower_arm_default_rotation_degrees;

    [ExportGroup("Left Upper leg")]
    [Export] public int left_upper_leg_bone_index;
    [Export] public CollisionShape3D left_upper_leg_collider;

    [Export]
    public Vector3
        left_upper_leg_default_position,
        left_upper_leg_default_rotation_degrees;

    [ExportGroup("Left Lower leg")]
    [Export] public int left_lower_leg_bone_index;
    [Export] public CollisionShape3D left_lower_leg_collider;

    [Export]
    public Vector3
        left_lower_leg_default_position,
        left_lower_leg_default_rotation_degrees;



    [ExportGroup("Right Upper leg")]
    [Export] public int right_upper_leg_bone_index;
    [Export] public CollisionShape3D right_upper_leg_collider;

    [Export]
    public Vector3
        right_upper_leg_default_position,
        right_upper_leg_default_rotation_degrees;

    [ExportGroup("Right Lower leg")]
    [Export] public int right_lower_leg_bone_index;
    [Export] public CollisionShape3D right_lower_leg_collider;

    [Export]
    public Vector3
        right_lower_leg_default_position,
        right_lower_leg_default_rotation_degrees;

    #endregion

    public override void _EnterTree()
    {
        if (!Engine.IsEditorHint())
        {
            idamagable = (IDamagable)GetNode(idamagable_path);
            idamagable_path.Dispose();
        }
    }
    public override void _PhysicsProcess(double delta)
    {
        if (skeleton == null) return;

        Transform3D temp_transform;
        if (head_collider != null)
        {
            temp_transform.Origin = head_default_position;
            temp_transform.Basis = Basis.FromEuler(head_default_rotation_degrees * MathUtil.DegToRad);
            head_collider.Transform = skeleton.GetBoneGlobalPose(head_bone_index) * temp_transform;
        }

        if (upper_body_collider != null)
        {
            temp_transform.Origin = upper_body_default_position;
            temp_transform.Basis = Basis.FromEuler(upper_body_default_rotation_degrees * MathUtil.DegToRad);
            upper_body_collider.Transform = skeleton.GetBoneGlobalPose(upper_body_bone_index) * temp_transform;
        }

        if (lower_body_collider != null)
        {
            temp_transform.Origin = lower_body_default_position;
            temp_transform.Basis = Basis.FromEuler(lower_body_default_rotation_degrees * MathUtil.DegToRad);
            lower_body_collider.Transform = skeleton.GetBoneGlobalPose(lower_body_bone_index) * temp_transform;
        }

        if (left_upper_arm_collider != null)
        {
            temp_transform.Origin = left_upper_arm_default_position;
            temp_transform.Basis = Basis.FromEuler(left_upper_arm_default_rotation_degrees * MathUtil.DegToRad);
            left_upper_arm_collider.Transform = skeleton.GetBoneGlobalPose(left_upper_arm_bone_index) * temp_transform;
        }
        if (left_lower_arm_collider != null)
        {
            temp_transform.Origin = left_lower_arm_default_position;
            temp_transform.Basis = Basis.FromEuler(left_lower_arm_default_rotation_degrees * MathUtil.DegToRad);
            left_lower_arm_collider.Transform = skeleton.GetBoneGlobalPose(left_lower_arm_bone_index) * temp_transform;
        }
        if (right_upper_arm_collider != null)
        {
            temp_transform.Origin = right_upper_arm_default_position;
            temp_transform.Basis = Basis.FromEuler(right_upper_arm_default_rotation_degrees * MathUtil.DegToRad);
            right_upper_arm_collider.Transform = skeleton.GetBoneGlobalPose(right_upper_arm_bone_index) * temp_transform;
        }
        if (right_lower_arm_collider != null)
        {
            temp_transform.Origin = right_lower_arm_default_position;
            temp_transform.Basis = Basis.FromEuler(right_lower_arm_default_rotation_degrees * MathUtil.DegToRad);
            right_lower_arm_collider.Transform = skeleton.GetBoneGlobalPose(right_lower_arm_bone_index) * temp_transform;
        }
        if (left_upper_leg_collider != null)
        {
            temp_transform.Origin = left_upper_leg_default_position;
            temp_transform.Basis = Basis.FromEuler(left_upper_leg_default_rotation_degrees * MathUtil.DegToRad);
            left_upper_leg_collider.Transform = skeleton.GetBoneGlobalPose(left_upper_leg_bone_index) * temp_transform;
        }
        if (left_lower_leg_collider != null)
        {
            temp_transform.Origin = left_lower_leg_default_position;
            temp_transform.Basis = Basis.FromEuler(left_lower_leg_default_rotation_degrees * MathUtil.DegToRad);
            left_lower_leg_collider.Transform = skeleton.GetBoneGlobalPose(left_lower_leg_bone_index) * temp_transform;
        }
        if (right_upper_leg_collider != null)
        {
            temp_transform.Origin = right_upper_leg_default_position;
            temp_transform.Basis = Basis.FromEuler(right_upper_leg_default_rotation_degrees * MathUtil.DegToRad);
            right_upper_leg_collider.Transform = skeleton.GetBoneGlobalPose(right_upper_leg_bone_index) * temp_transform;
        }
        if (right_lower_leg_collider != null)
        {
            temp_transform.Origin = right_lower_leg_default_position;
            temp_transform.Basis = Basis.FromEuler(right_lower_leg_default_rotation_degrees * MathUtil.DegToRad);
            right_lower_leg_collider.Transform = skeleton.GetBoneGlobalPose(right_lower_leg_bone_index) * temp_transform;
        }
    }
}
